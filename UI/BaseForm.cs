using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class BaseForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private ISender _mediator = null!;

        protected ISender Mediator => _mediator ??= Program.ServiceProvider.GetRequiredService<ISender>();

        protected void HandleResult<T>(Result<T> result)
        {
            if (result.ResourceCreated)
            {
                var dialogResult = MessageBox.Show(result.CreatedMessage, "Operación exitosa",MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                    this.Close();
                        
            }
            else if (result.IsSucess == false)
            {
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected BindingSource CreateBindingSource<T>(List<T> data)
        {
            BindingSource bindingSource = new BindingSource();

            foreach (var item in data)
            {
                bindingSource.Add(item);
            }

            return  bindingSource;
        }
    }
}
