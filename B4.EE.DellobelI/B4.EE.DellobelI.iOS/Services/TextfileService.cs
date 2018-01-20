using B4.EE.DellobelI.Domain.Services.Abstract;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(B4.EE.DellobelI.iOS.Services.TextfileService))]

namespace B4.EE.DellobelI.iOS.Services
{
    public  class TextfileService : TTextfileService
    {
        public async Task SaveText(string filename, string text)
        {
            var documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            File.WriteAllText(filePath, text);
            await Task.Delay(0);
        }



        public async Task<string> LoadText(string filename)
        {
            var documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            await Task.Delay(0);
            return File.ReadAllText(filePath);
        }
    }
}