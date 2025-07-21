using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmNewOrder : MaterialForm
    {
        public FrmNewOrder()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Orange700,
                TextShade.WHITE
            );
        }

        private void PbImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Title = "Selecciona una imagen";
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void PbImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && EsArchivoImagen(files[0]))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void PbImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && EsArchivoImagen(files[0]))
            {
                pbImage.Image = Image.FromFile(files[0]);
            }
        }

        private static bool EsArchivoImagen(string file)
        {
            string ext = System.IO.Path.GetExtension(file).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        #region Validaciones de texto

        private void TxtSanitizar_TextChanged(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;
            string texto = SanitizarTexto(txt.Text);
            if (txt.Text != texto)
            {
                int pos = txt.SelectionStart - (txt.Text.Length - texto.Length);
                txt.Text = texto;
                txt.SelectionStart = pos > 0 ? pos : 0;
            }
        }

        private static string SanitizarTexto(string input)
        {
            string pattern = @"[;'\-""\\/*%]";
            return Regex.Replace(input, pattern, string.Empty);
        }

        private void TxtClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtClient_TextChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtClient.Text, @"[^\d]", "");
            if (texto.Length > 10)
                texto = texto[..10];
            if (txtClient.Text != texto)
                txtClient.Text = texto;
            txtClient.SelectionStart = txtClient.Text.Length;
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtQuantity.Text, @"[^\d]", "");
            if (txtQuantity.Text != texto)
                txtQuantity.Text = texto;
            txtQuantity.SelectionStart = txtQuantity.Text.Length;
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClient.Text) ||
               (txtClient.Text.Length != 10 && txtClient.Text.Length != 13) ||
               string.IsNullOrWhiteSpace(txtQuantity.Text) ||
               string.IsNullOrWhiteSpace(txtDevSpec.Text) ||
               string.IsNullOrWhiteSpace(txtFailDesc.Text))
            {
                MessageBox.Show("Todos los campos obligatorios deben estar completos y correctos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pbImage.Image == null)
            {
                var result = MessageBox.Show("No se ha seleccionado una imagen. ¿Desea continuar sin imagen?", "Imagen opcional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
        }

        #endregion

        private void txtFailDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
