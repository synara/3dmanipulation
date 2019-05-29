using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing.CG.Uni7.VF.Imagem
{
    public class CuboTeste
    {
        private BufferedGraphics graphicsBuffer;
        private BufferedGraphicsContext bufferContext;
        private object panelRender;

        public CuboTeste()
        {
            bufferContext = BufferedGraphicsManager.Current;
        }

    }
}
