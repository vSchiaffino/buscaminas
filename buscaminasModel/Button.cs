using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscaminasModel
{
    public class Model_button
    {
        // 0 = nothing
        // 1 = flag
        // 2 = question
        int flag = 0;

        bool clicked = false;
        // number = -1: BOMB
        // number >= 0: Clicked
        int number;
        List<int> pos;
        public Model_button(int row, int col)
        {
            this.pos = new List<int>();
            this.pos.Add(row);
            this.pos.Add(col);
        }

        public int getNumber()
        {
            return !isClicked() ? 0 : number;
        }

        public bool Click(bool isLeftClick, ButtonsGrid buttonsGrid)
        {
            if (isLeftClick)
            {
                if (isBomb()) return true;
                else
                {
                    if (flag == 1) return false;
                    if (!clicked)
                    {
                        clicked = true;
                        flag = 0;
                        if(number == 0)
                        {
                            var neighbors = buttonsGrid.GetNeighbors(this.pos[0], this.pos[1]);
                            foreach (Model_button neighbor in neighbors)
                            {
                                neighbor.VecinoClickeado(buttonsGrid);
                            }
                        }
                    }
                }
            }
            else
            {
                if(!isClicked())
                flag = flag == 2 ? 0 : flag + 1;
            }
            return false;
        }

        public void VecinoClickeado(ButtonsGrid buttonsGrid)
        {
            if(this.number == 0 && !clicked)
            {
                clicked = true;
                var neighbors = buttonsGrid.GetNeighbors(this.pos[0], this.pos[1]);
                foreach (Model_button neighbor in neighbors)
                {
                    neighbor.VecinoClickeado(buttonsGrid);
                }
            }
            else
            {
                SetClick();
            }
        }

        public int getFlag()
        {
            return flag;
        }

        public void SetClick()
        {
            if (isBomb())
            {
                Console.Write("Valen te confundiste");
            }
            else
            {
                clicked = true;
            }
        }

        public bool isBomb()
        {
            return number == -1;
        }

        public bool isHidden()
        {
            return !clicked;
        }

        public bool isFlagged()
        {
            return flag == 1 || flag == 2;
        }

        public bool isClicked()
        {
            return clicked;
        }

        public void setBomb()
        {
            number = -1;
        }

        public void setNumber(ButtonsGrid buttonsGrid)
        {
            if (number == -1) return;
            int n = 0;
            var neighbors = buttonsGrid.GetNeighbors(this.pos[0], this.pos[1]);
            foreach (Model_button neighbor in neighbors)
            {
                if (neighbor.isBomb()) n += 1;
            }
            this.number = n;
        }

    }
}
