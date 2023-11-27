﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles.UI {
    internal class Character : INotifyPropertyChanged {
        private int constitution;
        private int dexterity;
        private int weaponSkill;
        private int forcePower;
        private int blasterSkill;
        private int charisma;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Character() {
            constitution = 8;
            dexterity = 8;
            weaponSkill = 8;
            forcePower = 8;
            blasterSkill = 8;
            charisma = 8;
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
        public int Charisma {
            get {
                return this.charisma;
            }
            set {
                this.charisma = value;
                NotifyPropertyChanged();
            }
        }
    }
}