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
    public class AssoToolForLaunch : INotifyPropertyChanged
    {
        private readonly string _mmAppName = "DiagramDesigner.exe";

        private string mName;

        public string Name

        {

            get { return mName; }

            set
            {
                mName = value;
                OnPropertyChanged();
            }

        }



        private string mFilePath;



        public string FilePath

        {

            get { return mFilePath; }

            set
            {
                mFilePath = value;
                OnPropertyChanged();
            }

        }

        private string mLaunchParams;

        public string LaunchParams
        {
            get { return mLaunchParams; }
            set { mLaunchParams = value; }
        }


        private string mDescription;



        public string Description

        {

            get { return mDescription; }

            set
            {
                mDescription = value;
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

        private static BindingList<AssoToolForLaunch> allObjects;
        public static BindingList<AssoToolForLaunch> GetData(int count)
        {
            if (allObjects == null)
                LoadData();
            BindingList<AssoToolForLaunch> bindingList = new BindingList<AssoToolForLaunch>();
            for (int index = 0; index < count; ++index)
                bindingList.Add(allObjects[index % allObjects.Count]);
            return (BindingList<AssoToolForLaunch>)bindingList;
        }

        public static BindingList<AssoToolForLaunch> LoadData()
        {
            if (allObjects == null)
                allObjects = new BindingList<AssoToolForLaunch>();
            else
                return allObjects;
            BindingList<AssoToolForLaunch> bindingList = allObjects;
            bindingList.Add(new AssoToolForLaunch()
            {
                Name = "Create scheme From Scratch",
                FilePath = @"\Tools\Mindmap\",
                LaunchParams="",
                Description= "Description DescriptionD escription Description Description Description Description",
                Picture = ImageUtilities.GetRandomImage(50, 50)
            });
            bindingList.Add(new AssoToolForLaunch()
            {
                Name = "Create scheme from MD note",
                FilePath = "2",
                LaunchParams = "",
                Description = "Description DescriptionD escription Description Description Description Description",
                Picture = ImageUtilities.GetRandomImage(50, 50)
            });
            return bindingList;
        }

        


    }


}
