using System;
using System.Xml.Serialization;
using System.IO;

namespace SR4 {
    class MainClass {
        public static void Main(string[] args) {
            Triangle.Triangle[] triangles;

            try {
                var stream = new FileStream("../../../triangles.xml", FileMode.Open);

                var format = new XmlSerializer(typeof(Triangle.Triangle[]));

                triangles = format.Deserialize(stream) as Triangle.Triangle[];

                Array.Sort(triangles);

                foreach (var triangle in triangles) {
                    Console.WriteLine(triangle);
                }

            } catch {
                Console.WriteLine("There was an error reading the file.");
            }
        }
    }
}
