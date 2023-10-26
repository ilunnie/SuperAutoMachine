// using System.Drawing;
// using System.Windows.Forms;

// public class ExampleApp : App
// {
//     Image moeda = Image.FromFile("Img/moeda.png");
//     Image coracao = Image.FromFile("Img/coracao.png");
//     bool fundiu = false;
//     bool clicked = false;
//     Player player = new Player();
//     player.Add(new ChaveDeFenda(), 0);

//     public override void OnFrame(bool isDown, PointF cursor)
//     {

//         foreach (var piece in player.pieces)
//         {
//             if(piece != null)
//                 DrawPiece(new RectangleF(300, 300, 200, 200), piece.Ataque, piece.Vida, piece.Xp, piece.Tier, true, piece.GetType().Name);
            
//         }

//         DrawImage((Bitmap)moeda, new RectangleF(1050, 300, 100, 60));
//         // DrawText(player.Gold.ToString(), Color.Black, new RectangleF(1050, 300, 100, 60));

//         DrawImage((Bitmap)coracao, new RectangleF(1050, 500, 100, 100));
//         // DrawText(player.Hearts.ToString(), Color.White, new RectangleF(1050, 500, 100, 100));


//         if (!clicked)
//         {
//             clicked = DrawButton(new RectangleF(400, 800, 200, 100), "Iniciar");
//             if (clicked)
//                 MessageBox.Show("Clicou");
//         }
//     }
// }