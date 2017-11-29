  try
            {
                txt = textBlock.Text.Replace(",", "").Replace(".", "");
                if (txt.Equals(""))
                {
                    textBlock.Text = "0,00";
                }
                if (valor > 10)
                {
                    txt = txt.Remove(3);
                }
                if (valor > 2)
                {
                    txt = txt.Remove(txt.Length - 1);
                }
                //if (valor == 0)
                //{
                //    txt = txt.Remove(txt.Length - 1);
                //}
                //txt = txt.PadLeft(3, '0');
                if (txt.Length > 3 & txt.Substring(0, 1) == "0")
                    txt = txt.Substring(1, txt.Length - 1);
                 valor = Convert.ToDecimal(txt) / 100;

                if (valor != 0)
                {
                    textBlock.Text = string.Format("{0:N}", valor);
                    textBlock.SelectionStart = textBlock.Text.Length;
                }
                else
                {
                    //textBlock.Text = txt;
                }
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
