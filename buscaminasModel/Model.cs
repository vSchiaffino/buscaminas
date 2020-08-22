using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscaminasModel
{
    public class Model
    {
        ButtonsGrid buttonsGrid;
        public Model(int filas, int columnas, int bombas)
        {
            buttonsGrid = new ButtonsGrid(filas, columnas, bombas);
        }

        public Model_button GetModelButton(List<int> tag)
        {
            return buttonsGrid.GetButtonByMove(tag[0], tag[1], 0, 0);
        }

        public string Click(List<int> tag, bool isLeftButton)
        {
            var clickedButton = buttonsGrid.GetButtonByMove(tag[0], tag[1], 0, 0);
            var res = clickedButton.Click(isLeftButton, buttonsGrid);
            if (buttonsGrid.checkWin())
            {
                return "win";
            }
            else
            {
                return res ? "lose" : "active";
            }
        }
    }
}
