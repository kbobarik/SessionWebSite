using System.Reflection;

namespace SessionWebSite
{
    public  class Smeshariki
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int? Gender { get; set; }

        public int Age { get; set; }

        public string Animal { get; set; } = null!;

        public byte[]? Image { get; set; }

    }
}
