      if (!string.IsNullOrEmpty(textBlock.Text))
            {
                try
                {
                    double numer = Convert.ToDouble(textBlock.Text);
                    txt = textBlock.Text.Replace(",", "").Replace(".", "");
                    if (valor > 10)
                    {
                        txt = txt.Remove(3);
                    }
                    if (valor > 2)
                    {
                        txt = txt.Remove(txt.Length - 1);
                    }

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

                }
            }
            else
            {
                string.IsNullOrEmpty(textBlock.Text);
            }
        }
