using System;
using static Iko.Iko;
using Triangle;
using System.Xml.Serialization;
using System.IO;

namespace Write {
    class MainClass {

        static Random rand = new Random();

        public static void Main() {
            var n = GetInt("N = ", x => x > 0, "That is not a valid integer, larger than 0.");
            var triangles = new Triangle.Triangle[n];

            for (var i = 0; i < n; i++) {
                triangles[i] = new Triangle.Triangle();
                triangles[i].A = rand.NextDouble() * 29 + 1;
                triangles[i].B = rand.NextDouble() * 29 + 1;
            }

            try {
                var stream = new FileStream("../../../triangles.xml", FileMode.Create);

                var format = new XmlSerializer(typeof(Triangle.Triangle[]));

                format.Serialize(stream, triangles);
            } catch {
                Console.WriteLine("There was an error writing the file.");
            }
        }
    }
}
