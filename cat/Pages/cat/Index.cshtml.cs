using Microsoft.AspNetCore.Mvc.RazorPages;
using cat.Models;
using System.Collections.Generic;

namespace cat.Pages.cat
{
    public class IndexModel : PageModel
    {
        public List<p> Products { get; set; } = new List<p>();

        public void OnGet()
        {
            Products = new List<p>
            {
                new p
                {
                    Id = 1,
                    Name = "Ќоутбук",
                    Category = "Ёлектроника",
                    Description = "крутой ноутбук дл€ игр",
                    Price = 1159999,
                    Image = "https://avatars.mds.yandex.net/get-altay/1777247/2a0000016d9b15915e0ed278b29f35489f29/XXL_height"
                },
                new p
                {
                    Id = 2,
                    Name = "айфон 67 промакс",
                    Category = "Ёлектроника",
                    Description = "256 гб пикми телефон, топ дн€, лучша€ камера и огромна€ аура  (трипофобам не покупать!)",
                    Price = 199999,
                    Image = "https://avatars.mds.yandex.net/i?id=09f620cd60d54297d6e56ebff7e5c10d1f4bc53b-5234908-images-thumbs&n=13"
                },
                new p
                {
                    Id = 3,
                    Name = "наушники",
                    Category = "Ёлектроника",
                    Description = "наушиники дл€ самых мужественных игроков доты",
                    Price = 21999,
                    Image = "https://avatars.mds.yandex.net/i?id=6ec4dfba688b0357f72a6024ddf4657557c540d1-4476027-images-thumbs&n=13"
                },
                new p
                {
                    Id = 4,
                    Name = "шорты",
                    Category = "ќдежда",
                    Description = "спортивные шорты желтые дл€ крутых ххххл размер",
                    Price = 1489,
                    Image = "https://avatars.mds.yandex.net/i?id=993fb020ebdb80d4ed5e6b79c2ab8c6c_l-5334229-images-thumbs&n=13"
                },
                new p
                {
                    Id =5,
                    Name = "€йца",
                    Category = "≈да",
                    Description = "куриные с0 вкусн€тина",
                    Price = 159,
                    Image = "https://avatars.mds.yandex.net/i?id=bb339b24c32087ea2352a88b2b7fab61_l-4258580-images-thumbs&n=13"
                },
                new p
                {
                    Id = 6,
                    Name = "таритос",
                    Category = "ѕитомцы",
                    Description = "корм дл€ домашних €щериц",
                    Price = 679,
                    Image = "https://avatars.mds.yandex.net/i?id=1aa871007eef2db971799978e3874626_l-12421637-images-thumbs&n=13"
                }
            };
        }
    }
}