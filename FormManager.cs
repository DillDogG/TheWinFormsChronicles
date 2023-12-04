using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles {
    internal class FormManager : ApplicationContext {
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;

        public FormManager()
        {
            //var f1 = CreateForm<Form1>();
            //f1.Show();
            //var f2 = CreateForm<Form2>();
            //f2.ShowDialog();
            //var f3 = CreateForm<Form3>();
            //f3.Show();
        }

        public void OpenCharacterStats(bool first = true)
        {
            var f = CreateForm<Form1>();
            f.Show();
            if (!first)
            {
                f.setCharacter();
            }
        }

        public void OpenBattlePage()
        {
            var f = CreateForm<Form3>();
            f.Show();
        }

        private void onFormClosed(object sender, EventArgs e) {
            if (Application.OpenForms.Count == 0) {
                ExitThread();
            }
        }

        public T CreateForm<T>() where T : Form, new()
        {
            var ret = new T();
            ret.FormClosed += onFormClosed;
            return ret;
        }
    }
}
