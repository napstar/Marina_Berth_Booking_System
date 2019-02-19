using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MarinaBerthClassLibrary
{
    public class Boat:IBoat
    {
        private int maxLength;
        private int maxDraft;
        private string nameOfBoat, nameOfOwner;

        public int MaxLength
        {
            get
            {
                return maxLength;
            }

            set
            {
                maxLength = value;
            }
        }

        public int MaxDraft
        {
            get
            {
                return maxDraft;
            }

            set
            {
                maxDraft = value;
            }
        }

        public string NameOfBoat
        {
            get
            {
                return nameOfBoat;
            }

            set
            {
                nameOfBoat = value;
            }
        }

        public string NameOfOwner
        {
            get
            {
                return nameOfOwner;
            }

            set
            {
                nameOfOwner = value;
            }
        }

        enum BoatType
        {
            Sailing,
            Motor,
            Narrow
            
        }

        public void dock()
        {
            throw new NotImplementedException();
        }

        public void unDock()
        {
            throw new NotImplementedException();
        }
    }
}