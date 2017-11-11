using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace colours_of_the_rainbow
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void btn_readColours_Click(object sender, EventArgs e)
        {
            // > Create array of objects
            colour[] colour_array1 = new colour[10];
            colour colour          = new colour();

            // > Create data

            colour new_colour = new colour();
            new_colour.colour_name = "red";
            new_colour.colour_hexcode = "#FF0000";
            new_colour.colour_rgba = "rbga(255, 0, 0, 1)";
            colour_array1[0] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "yellow";
            new_colour.colour_hexcode = "#FFFF00";
            new_colour.colour_rgba = "rbga(255, 255, 0, 1)";
            colour_array1[1] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "lime";
            new_colour.colour_hexcode = "#00FF00";
            new_colour.colour_rgba = "rbga(0, 255, 0, 1)";
            colour_array1[2] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "blue";
            new_colour.colour_hexcode = "#0000FF";
            new_colour.colour_rgba = "rbga(0, 0, 255, 1)";
            colour_array1[3] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "purple";
            new_colour.colour_hexcode = "#800080";
            new_colour.colour_rgba = "rbga(128, 0, 128, 1)";
            colour_array1[4] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "aqua";
            new_colour.colour_hexcode = "#00FFFF";
            new_colour.colour_rgba = "rbga(0, 255, 255, 1)";
            colour_array1[5] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "green";
            new_colour.colour_hexcode = "#008000";
            new_colour.colour_rgba = "rbga(0, 128, 0, 1)";
            colour_array1[6] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "fuchsia";
            new_colour.colour_hexcode = "#FF00FF";
            new_colour.colour_rgba = "rbga(255, 0, 255, 1)";
            colour_array1[7] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "maroon";
            new_colour.colour_hexcode = "#800000";
            new_colour.colour_rgba = "rbga(128, 0, 0, 1)";
            colour_array1[8] = new_colour;

            new_colour = new colour();
            new_colour.colour_name = "navy";
            new_colour.colour_hexcode = "#000080";
            new_colour.colour_rgba = "rbga(0, 0, 128, 1)";
            colour_array1[9] = new_colour;

            // > Convert to JSON
            string output = JsonConvert.SerializeObject(colour_array1);

            // > Display JSON
            rtb_json.Text = output;

            // > Write this JSON to a file (debug folder)
            using (StreamWriter file = File.CreateText(@"colours1.txt"))
            {
                JsonSerializer s = new JsonSerializer();
                s.Serialize(file, output);
            }

            // > Read the JSON
            colour[] json_colour_array1 = JsonConvert.DeserializeObject<colour[]>(output);

            // > Populate list view
            lv_colours.View = View.Details;
            lv_colours.GridLines = true;

            foreach (var c in colour_array1)
                lv_colours.Items.Add(new ListViewItem(new string[] {c.colour_name, c.colour_hexcode, c.colour_rgba }));
            
            // > Deactivate button
            btn_readColours.Enabled = false;
        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            // > Reads the pre-written JSON file 'colours2' (debug folder)
            string json_file = File.ReadAllText(@"colours2.txt");

            colour[] json_colour_array2 = JsonConvert.DeserializeObject<colour[]>(json_file);

            // > Display JSON
            rtb_json.Text = json_file;

            // > Populate list view
            lv_colours.View = View.Details;
            lv_colours.GridLines = true;

            foreach (var c in json_colour_array2)
                lv_colours.Items.Add(new ListViewItem(new string[] { c.colour_name, c.colour_hexcode, c.colour_rgba }));

            // > Deactivate button
            btn_readFile.Enabled = false;
        }
    }
}
