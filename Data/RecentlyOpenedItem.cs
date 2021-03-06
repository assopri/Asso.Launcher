using Asso.Launcher.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asso.Launcher.Data
{
    public class RecentlyOpenedItem : INotifyPropertyChanged
    {

        private string mName;



        public string Name

        {

            get { return mName; }

            set { mName = value;
                OnPropertyChanged();
            }

        }



        private string mFilePath;



        public string FilePath

        {

            get { return mFilePath; }

            set { mFilePath = value;
                OnPropertyChanged();
            }

        }



        private DateTime _lastTimeOpened;



        public DateTime LastTimeOpened

        {

            get { return _lastTimeOpened; }

            set { _lastTimeOpened = value;
                OnPropertyChanged();
            }

        }

        private ProjectType mProjectType;


        public ProjectType ProjectType

        {

            get { return mProjectType; }

            set
            {
                mProjectType = value;
                OnPropertyChanged();
            }

        }
        public Image Picture
        {
            get
            {
                return _Picture;
            }
            set
            {
                _Picture = value;
                OnPropertyChanged();
            }
        }


        private Image _Picture;

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private static BindingList<RecentlyOpenedItem> allObjects;
        public static BindingList<RecentlyOpenedItem> GetData(int count)
        {
            if (allObjects == null)
                LoadData();
            BindingList<RecentlyOpenedItem> bindingList = new BindingList<RecentlyOpenedItem>();
            for (int index = 0; index < count; ++index)
                bindingList.Add(allObjects[index % allObjects.Count]);
            return (BindingList<RecentlyOpenedItem>)bindingList;
        }

        public static BindingList<RecentlyOpenedItem> LoadData()
        {
            if (allObjects == null)
                allObjects = new BindingList<RecentlyOpenedItem>();
            else
                return allObjects;
            BindingList<RecentlyOpenedItem> bindingList = allObjects;
            bindingList.Add(new RecentlyOpenedItem()
            {
                Name = "testName",
                FilePath = "1",
                LastTimeOpened = DateTime.Now,
                ProjectType = ProjectType.TypeA,
                Picture = ImageUtilities.GetRandomImage(50, 50)
            });
            bindingList.Add(new RecentlyOpenedItem()
            {
                Name = "testName2",
                FilePath = "2",
                LastTimeOpened = DateTime.Now,
                ProjectType = ProjectType.TypeB,
                Picture = ImageUtilities.GetRandomImage(50, 50)
            });
            return bindingList;
        }



    }



    public enum ProjectType

    {

        TypeA,

        TypeB

    }
}
