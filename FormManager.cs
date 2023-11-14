using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWinFormsChronicles {
    internal class FormManager : ApplicationContext {
        private static Lazy<FormManager> _current = new Lazy<FormManager>(());
        public static FormManager Current => _current.Value;

        public FormManager()
        {
            var f1 = CreateForm<Form1>();
            f1.Show();
            var f2 = CreateForm<Form2>();
            f2.ShowDialog();
        }

        private void onFormClosed(object sender, EventArgs e) {
            if (Application.OpenForms.Count == 0) {
                ExitThread();
            }
        }
    }

    public T CreateForm<T>
}
