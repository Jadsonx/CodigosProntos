  private void BoxNota100_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            if (!string.IsNullOrEmpty(entry.Text))
            {
                try
                {
                    double texto = Convert.ToDouble(entry.Text);

                    if (texto == 0)
                    {
                        var ev = e as TextChangedEventArgs;
                        if (ev.NewTextValue != ev.OldTextValue)
                        {
                            string text = Regex.Replace(e.NewTextValue, @"[^0-9]", "");

                            if (text.Length > 3)
                                text = text.Remove(3);

                            double Texto = Convert.ToDouble(entry.Text);

                            if (text.Length > 1)
                            {
                                text = text.Insert(1, ",");
                            }

                            if (entry.Text != text)
                                entry.Text = text;
                        }
                    }
                    else
                    {
                        try
                        {
                            txt = entry.Text.Replace(",", "").Replace(".", "");
                            if (txt.Equals(""))
                            {
                                entry.Text = "";
                            }
                            if (texto > 10)
                            {
                                txt = txt.Remove(3);
                            }
                            txt = txt.PadLeft(3, '0');
                            if (txt.Length > 3 & txt.Substring(0, 1) == "0")
                                txt = txt.Substring(1, txt.Length - 1);
                            valor = Convert.ToDecimal(txt) / 100;
                            entry.Text = string.Format("{0:N}", valor);

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                    }

                }
                catch
                {
                    entry.Text = "";
                }
            }
         }
