 private void textChanged(object obj, EventArgs e) {
            try {
                txt = txtBox.Text.Replace(",", "").Replace(".", "");
                if (txt.Equals("")) {
                    txtBox.Text = "0,00";
                }
                txt = txt.PadLeft(3, '0');                
                if (txt.Length > 3 & txt.Substring(0, 1) == "0")
                    txt = txt.Substring(1, txt.Length - 1);
                valor = Convert.ToDecimal(txt) / 100;
                txtBox.Text = string.Format("{0:N}", valor);
                txtBox.SelectionStart = txtBox.Text.Length;
            }catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }            
        }
