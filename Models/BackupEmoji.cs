using Discord;
using System.Net.Http;

namespace GLaDOSV3.Module.ServerBackup.Models
{
    internal class BackupEmoji
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public BackupEmoji(GuildEmote e)
        {
            if (e == null) return;
            Name = e.Name;

            using HttpClient wc = new HttpClient();
            Image = wc.GetByteArrayAsync(e.Url).GetAwaiter().GetResult();
        }
    }
}
