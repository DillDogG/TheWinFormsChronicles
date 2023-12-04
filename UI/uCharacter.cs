using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.UI {
    public class uCharacter : INotifyPropertyChanged {
        private int constitution;
        private int dexterity;
        private int charisma;
        private int weaponSkill;
        private int forcePower;
        private int blasterSkill;
        private int creationPoints;
        public event PropertyChangedEventHandler? PropertyChanged;

        public uCharacter() {
            constitution = 8;
            dexterity = 8;
            charisma = 8;
            weaponSkill = 8;
            forcePower = 8;
            blasterSkill = 8;
            creationPoints = 27;
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int Constitution {
            get {
                return this.constitution;
            }
            set {
                this.constitution = value;
                NotifyPropertyChanged();
            }
        }
        public int Dexterity {
            get {
                return this.dexterity;
            }
            set {
                this.dexterity = value;
                NotifyPropertyChanged();
            }
        }
        public int Charisma {
            get {
                return this.charisma;
            }
            set {
                this.charisma = value;
                NotifyPropertyChanged();
            }
        }
        public int WeaponSkill {
            get {
                return this.weaponSkill;
            }
            set {
                this.weaponSkill = value;
                NotifyPropertyChanged();
            }
        }
        public int ForcePower {
            get {
                return this.forcePower;
            }
            set {
                this.forcePower = value;
                NotifyPropertyChanged();
            }
        }
        public int BlasterSkill {
            get {
                return this.blasterSkill;
            }
            set {
                this.blasterSkill = value;
                NotifyPropertyChanged();
            }
        }
        public int CreationPoints {
            get {
                return this.creationPoints;
            }
            set {
                this.creationPoints = value;
                NotifyPropertyChanged();
            }
        }
    }
}
