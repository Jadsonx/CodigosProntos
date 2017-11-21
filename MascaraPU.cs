            var ev = e as TextChangedEventArgs;
            if (ev.NewTextValue != ev.OldTextValue)
            {
                var entry = (Entry)sender;

                string text = Regex.Replace(e.NewTextValue, @"[^0-9]", "");

                if (text.Length > 3)
                    text = text.Remove(3);

                double Texto = Convert.ToDouble(entry.Text);

                if (text.Length >= 1)
                {
                    text = text.Insert(1, ",");
                }

                if (Texto > 2)
                {
                    text = "";
                }

                if (entry.Text != text)
                    entry.Text = text;
            }
