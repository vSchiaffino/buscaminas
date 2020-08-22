using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscaminasModel
{
    public class ButtonsGrid : List<List<Model_button>>
    {
        int filas;
        int columnas;
        public ButtonsGrid(int filas, int columnas, int bombas): base()
        {
            // creo los botones
            this.filas = filas;
            this.columnas = columnas;
            for (int i = 0; i < filas; i++)
            {
                var list = new List<Model_button>();
                for (int j = 0; j < columnas; j++)
                {
                    list.Add(new Model_button(i, j));
                }
                Add(list);
            }
            // inicializo las bombas
            Random random = new Random();
            var bombas_elegidas = new List<List<int>>();
            for (int i = 0; i < bombas; i++)
            {
                while (true)
                {
                    var x = random.Next(0, filas);
                    var y = random.Next(0, columnas);
                    var pos = new List<int>();
                    pos.Add(x);
                    pos.Add(y);
                    // todo hacer funcionar esto bien
                    bool ya_existe = false;
                    foreach (List<int> bomba in bombas_elegidas)
                    {
                        if(bomba[0] == pos[0] && bomba[1] == pos[1])
                        {
                            ya_existe = true;
                            break;
                        }
                    }


                    if (!ya_existe)
                    {
                        bombas_elegidas.Add(pos);
                        break;
                    }
                }
            }
            foreach (List<int> bombaElegidas in bombas_elegidas)
            {
                this[bombaElegidas[0]][bombaElegidas[1]].setBomb();
            }
            foreach (List<Model_button> lista in this)
            {
                foreach (Model_button button in lista)
                {
                    button.setNumber(this);
                }
            }
        }

        internal bool checkWin()
        {
            foreach (List<Model_button> lista in this)
            {
                foreach (Model_button button in lista)
                {
                    if (!button.isBomb() && !button.isClicked()) return false;
                }
            }
            return true;
        }

        public List<Model_button> GetNeighbors(int row, int column)
        {
            var list = new List<Model_button>();
            var moves = new List<List<int>>();
            var moveUp = new List<int>();
            moveUp.Add(0);
            moveUp.Add(-1);
            var moveUpRight = new List<int>();
            moveUpRight.Add(1);
            moveUpRight.Add(-1);
            var moveRight = new List<int>();
            moveRight.Add(1);
            moveRight.Add(0);
            var moveBottomRight = new List<int>();
            moveBottomRight.Add(1);
            moveBottomRight.Add(1);
            var moveBottom = new List<int>();
            moveBottom.Add(0);
            moveBottom.Add(1);
            var moveBottomLeft = new List<int>();
            moveBottomLeft.Add(-1);
            moveBottomLeft.Add(1);
            var moveLeft = new List<int>();
            moveLeft.Add(-1);
            moveLeft.Add(0);
            var moveUpLeft = new List<int>();
            moveUpLeft.Add(-1);
            moveUpLeft.Add(-1);
            moves.Add(moveUp);
            moves.Add(moveUpRight);
            moves.Add(moveRight);
            moves.Add(moveBottomRight);
            moves.Add(moveBottom);
            moves.Add(moveBottomLeft);
            moves.Add(moveLeft);
            moves.Add(moveUpLeft);
            foreach (List<int> move in moves)
            {
                var possible_neighbor = this.GetButtonByMove(row, column, move[0], move[1]);
                if (!(possible_neighbor == null))
                {
                    list.Add(possible_neighbor);
                }
            }
            return list;
        }

        public Model_button GetButtonByMove(int row,int column,int movx,int movy)
        {
            var resx = row + movx;
            var resy = column + movy;
            if(resx < 0 || resy < 0 || resx >= this.filas || resy >= this.columnas)
            {
                return null;
            }
            else
            {
                return this[resx][resy];
            }
        }

    }
}
