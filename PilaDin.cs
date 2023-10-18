using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasDinamicas
{
    internal class PilaDin
    {
        Nodo sp;

        public PilaDin() 
        {
            Sp = null;
        }

        internal Nodo Sp { get => sp; set => sp = value; }

        public void DesplegarPila(PilaDin P, ListBox Lp)
        {
            Nodo q = null;
            Lp.Items.Clear();
            if (P.Sp != null)
            {
                q= P.Sp;
                while (q != null)
                {
                    Lp.Items.Add(q.Dato);
                    q = q.Liga;
                }
            }
        }

        public void Push(ref PilaDin p, int X)
        {
            Nodo q = new Nodo(X);
            if (p.Sp == null)
            {
                p.Sp = q;
            }
            else
            {
                q.Liga=p.Sp;
                p.Sp = q;
            }
        }

        public int Pop(ref PilaDin p)
        {
            int X = -1;
            Nodo q = null;
            if (p.Sp == null)
                MessageBox.Show("UNDERFLOW");
            else
            {
                q = p.Sp;
                X = p.Sp.Dato;
                p.Sp = p.Sp.Liga;
                q.Liga = null;
            }
            return X;
        }
    }
}
