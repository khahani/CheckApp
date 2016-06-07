using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tabaar.CheckApp.Extension;

namespace Tabaar.CheckApp.Model
{
    public class SchoolCollection : Dictionary<string, string>
    {

        public SchoolCollection()
        {
            this.AddSchools();
        }

        public static Dictionary<string, string> Current
        {
            get
            {
                return new SchoolCollection();
            }
        }

        public static string GetSchoolName(string code)
        {
            foreach (var item in Current)
            {
                if (item.Key == code)
                    return item.Value;
            }

            return string.Empty;
        }

        public static string GetSchoolCode(string schoolName)
        {
            foreach (var item in Current)
            {
                if (item.Value == schoolName)
                    return item.Key;
            }

            return string.Empty;
        }

        private void AddSchools()
        {
            string[,] schools = new string[,]
            {
                {"36", "پیش دبستانی 1"},
                {"44", "پیش دبستانی 2"},
                {"51", "پیش دبستانی 3"},
                {"69", "دبستان پسرانه 1"},
                {"77", "دبستان پسرانه 2"},
                {"85", "دبستان پسرانه 3"},
                {"93", "دبستان پسرانه 4"},
                {"002", "دبستان پسرانه 5"},
                {"101", "دبستان دخترانه 1"},
                {"119", "دبستان دخترانه 2"},
                {"127", "دبستان دخترانه 3"},
                {"135", "راهنمایی پسرانه 1"},
                {"143", "راهنمایی پسرانه 2"},
                {"150", "راهنمایی پسرانه 3"},
                {"168", "راهنمایی دخترانه 1"},
                {"176", "راهنمایی دخترانه 2"},
                {"184", "راهنمایی دخترانه 3"},
                {"192", "دبیرستان پسرانه 1"},
                {"200", "دبیرستان پسرانه 2"},
                {"218", "دبیرستان دخترانه 1"},
                {"226", "دبیرستان دخترانه 2"},
            };

            this.AddRange<string, string>(schools);
        }
    }
}
