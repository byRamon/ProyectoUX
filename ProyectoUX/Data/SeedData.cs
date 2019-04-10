using ProyectoUX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUX.Data
{
    public class SeedData
    {
        public static List<Peliculas> Contenido()
        {
            List<Peliculas> Contenido = new List<Peliculas>();
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Aquaman",
                    Descripcion = "Aquaman, una aventura llena de acción que abarca el vasto y visualmente sobrecogedor mundo submarino de los siete mares, nos devela los orígenes de Arthur Curry, mitad humano y mitad atlante, que emprende el viaje de su vida, uno que no solo lo obligará a enfrentarse a quien realmente es, sino que le permitirá descubrir si es merecedor de su destino: ser rey.",
                    Genero = "Acción,Aventura".Split(','),
                    Actores = "Amber Heard,Dolph Lundgren,Jason Momoa".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "El Grinch",
                    Descripcion = "Illumination y Universal Pictures presentan El Grinch, basada en el amado clásico del Dr. Seuss. El Grinch cuenta la historia de un cínico gruñón que va en una misión para robarse la Navidad, sólo para descubrir que su corazón ha cambiado gracias al generoso espíritu de una pequeña niña. Divertida, conmovedora y visualmente impresionante, ¡El Grinch es diversión para toda la familia!",
                    Genero = "Animación".Split(','),
                    Actores = "Benedict Cumberbatch,Rashida Jones".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Spider-Man: Un Nuevo Universo",
                    Descripcion = "Spider-Man: Un Nuevo Universo presenta a Miles Morales, un adolescente de Brooklyn, y a las ilimitadas posibilidades del nuevo universo de Spider - Man, donde más de uno puede llevar máscara.",
                    Genero = "Acción,Aventura".Split(','),
                    Actores = "Brian Henry,Hailee Steinfeld".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Misión submarino",
                    Descripcion = "En las profundidades del Océano Ártico, un capitán de un submarino estadounidense descubre que un golpe de estado secreto está en marcha en Rusia y que todos están en peligro. Arriesgando la tripulación, y tratando de proteger al país, el capitán tendrá que rescatar a un rehén de alto perfil y escabullirse a través de las aguas enemigas sin ser detectado.",
                    Genero = "Acción,Aventura".Split(','),
                    Actores = "Toby Stephens,Ilia Volok".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Jefa por accidente",
                    Descripcion = "Cuando la empleada de una gran tienda reinventa su vida y su estilo de vida, tiene la oportunidad de demostrarle a Madison Avenue que la astucia callejera es tan valiosa como un título universitario y que nunca es demasiado tarde para una segunda oportunidad.",
                    Genero = "Comedia".Split(','),
                    Actores = "Jennifer Lopez,Leah Remini".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Wifi Ralph",
                    Descripcion = "En WIFI RALPH, el chico torpe de los videojuegos (voz original en inglés de John C. Reilly) y su mejor amiga Vanellope von Schweetz (voz original en inglés de Sarah Silverman) dejan las comodidades del arcade",
                    Genero = "Acción,Aventura".Split(','),
                    Actores = "John C. Reilly,Sarah Silverman".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Ant-Man And The Wasp",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "ANT-MAN AND THE WASP, de Marvel Studios, es el nuevo capítulo en el Universo Cinematográfico de Marvel de los héroes que poseen la asombrosa habilidad de encogerse. Tras lo ocurrido en CAPITÁN AMÉRICA: CIVIL WAR, Scott Lang",
                    Actores = "Paul Rudd,Evangeline LillyMichael Peña".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Thor: Ragnarok",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "En THOR - RAGNAROK, de Marvel Studios, Thor se encuentra atrapado en el otro extremo del universo sin su poderoso martillo",
                    Actores = "Chris Hemsworth,Tom Hiddleston,Cate Blanchett".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Pantera Negra",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "PANTERA NEGRA, de Marvel Studios, sigue a T'Challa, quien después de la muerte de su padre, el Rey de Wakanda, regresa a su solitaria nación",
                    Actores = "Chadwick Boseman, Michael B. Jordan".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Spider - Man: De regreso a casa ",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Un joven Peter Parker/Hombre Araña comienza a navegar la nueva identidad encontrada como el superhéroe lanzador de la web.",
                    Actores = "Tom Holland,Michael Keaton".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Avengers: Infinity War",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Como parte de un recorrido cinematográfico sin precedentes de diez años, de creación y expansión del Universo Cinematográfico de Marvel",
                    Actores = "Robert Downey Jr.,Chris Hemsworth".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Los Increíbles 2",
                    Genero = "Animación".Split(','),
                    Descripcion = "La familia de superhéroes favorita de todos está de regreso en LOS INCREÍBLES 2, pero esta vez Helen (voz en inglés de Holly Hunter) ",
                    Actores = "Craig T. Nelson,Holly Hunter".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Christopher Robin",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Ahora que ha crecido, Christopher Robin se encuentra atrapado en un trabajo en el que está sobrecargado de responsabilidades, mal remunerado y con un futuro incierto",
                    Actores = "Ewan McGregor,Hayley Atwell".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Coco",
                    Genero = "Animación".Split(','),
                    Descripcion = "A pesar de la incomprensible prohibición de la música desde hace varias generaciones en su familia, Miguel sueña con convertirse en un músico consagrado",
                    Actores = "Luis Ángel Gómez Jaramillo,Gael García Bernal,Marco Antonio Solis".Split(','),
                    Anio = 2017,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Hotel Transylvania 3",
                    Genero = "Animación".Split(','),
                    Descripcion = "La familia se va de crucero para que Drácula (Adam Sandler) pueda tomarse vacaciones y abandonar por unos días su trabajo en el Hotel Transylvania",
                    Actores = "Aaron LaPlante, Adam Sandler".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "El Hombre-Araña 2",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "En SPIDER-MAN 2, la más nueva entrega de la serie taquillera de Spider-Man, basada en el héroe clásico de Marvel Comics, Tobey Maguire regresa como el afable Peter Parker",
                    Actores = "Tobey Maguire,Kirsten Dunst".Split(','),
                    Anio = 2004,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "The Amazing Spider-Man",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Peter (Andrew Garfield), un adolescente marginado, pasa los días intentando desentrañar el misterio de su pasado y ganarse el corazón de su amor del instituto, Gwen Stacy (Emma Stone)",
                    Actores = "Andrew Garfield,Emma Stone".Split(','),
                    Anio = 2012,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "El Hombre Araña 3",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Peter Parker (Tobey Maguire) finalmente tiene a la chica de sus sueños, Mary Jane Watson (Kirsten Dunst), ¡y la ciudad de Nueva York agoniza por la Spider-manía! Pero cuando un simbiótico y extraño alienígena vuelve negro el traje de Spider-Man",
                    Actores = "Kirsten Dunst,Topher Grace,Tobey Maguire".Split(','),
                    Anio = 2007,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Cómo cortar a tu patán",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Con Mariana Treviño y Camila Sodi. Para Amanda, todas las mujeres pueden ser exitosas, empoderadas y dueñas de su sexualidad",
                    Actores = "Camila Sodi,Mariana Treviño".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Todos queremos a alguien",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Con Karla Souza, José María Yazpik y Ben O’Toole. Una mujer exitosa y soltera le pide a su compañero de trabajo que pose como su novio en una boda familiar en México",
                    Actores = "Karla Souza,José María Yazpik".Split(','),
                    Anio = 2017,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "3 idiotas",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Lo que la universidad unió, no lo separe el hombre. Dos amigos embarcan en una aventura para encontrar a un compañero desaparecido.",
                    Actores = "Martha Higareda,Alfonso Dosal".Split(','),
                    Anio = 2017,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Así nomás",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Este es el inicio de mil aventuras disparatas para cumplir con su sueño. Una película para reír de inicio a fin y que deja una enseñanza de superación ante los obstáculos de la vida.",
                    Actores = "Franco Cabrera,Emilram Cossío".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Mentes poderosas",
                    Genero = "Ciencia ficción,Fantasía".Split(','),
                    Descripcion = "Después de que el Gobierno detenga a unos adolescentes con habilidades misteriosas y declare que son una amenaza, Ruby (Amandla Stenberg),",
                    Actores = "Amandla Stenberg, Mandy Moore".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Ready Player One",
                    Genero = "Ciencia ficción,Fantasía".Split(','),
                    Descripcion = "Del cineasta Steven Spielberg, llega la aventura Ready Player One, basada en el exitoso libro de Ernest Cline del mismo nombre, el cual se ha convertido en un fenómeno mundial.",
                    Actores = "Tye Sheridan,Olivia Cooke".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Las travesuras de Peter Rabbit",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Adaptación del cuento clásico de Beatrix Potter de un conejo rebelde y de lo más revoltoso que intenta hacerse con el control de la huerta de un granjero.",
                    Actores = "Rose Byrne,Domhnall Gleeson".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Titanes Del Pací­fico",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "El aclamado cineasta Guillermo del Toro (El laberinto del fauno) saca la artillería pesada en esta épica de acción y ciencia ficción sobre un heterogéneo grupo de humanos que en el año 2025 se unen para luchar contra legiones de criaturas monstruosa",
                    Actores = "Charlie Hunnam, Idris Elba".Split(','),
                    Anio = 2013,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Animales fantásticos y dónde encontrarlos",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Fantastic Beasts and Where to Find Them” comienza en 1926 a medida que Newt Scamander acaba de terminar una excursión por todo el mundo para encontrar y documentar",
                    Actores = "Eddie Redmayne,Katherine Waterston".Split(','),
                    Anio = 2016,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "El regreso de Mary Poppins",
                    Genero = "Animación".Split(','),
                    Descripcion = "Londres, años 30, durante la era de la Gran Depresión. Los hermanos Michael (Ben Whishaw) y Jane Banks (Emily Mortimer), los personajes a quienes conocimos como niños en Mary Poppins, han crecido. Ahora viven juntos con los tres hijos de Michael y su sirvienta Ellen (Julie Walters) en Cherry Tree Lane.",
                    Actores = "Emily Blunt,Lin - Manuel Miranda ".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Misión: Imposible - Repercusión ",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "En una peligrosa misión para recuperar plutonio robado, Ethan Hunt (Tom Cruise) decide salvar a su equipo en vez de completar la misión",
                    Actores = "Tom Cruise,Henry Cavill".Split(','),
                    Anio = 2018,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Deadpool",
                    Genero = "Ciencia ficción,Fantasía".Split(','),
                    Descripcion = "Se testigo del origen de Wade Wilson, quien adopta el alter ego Deadpool después de que un experimento lo deja con extraordinarios y rápidos poderes curativos",
                    Actores = "Ryan Reynolds,Morena Baccarin".Split(','),
                    Anio = 2016,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Búsqueda implacable",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Cuando la distante hija de un ex-espía (Neeson), es secuestrada en París, su padre se dispone a encontrarla a cualquier pre",
                    Actores = "Liam Neeson,Maggie Grace".Split(','),
                    Anio = 2008,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Harry Potter y Las Reliquias de la Muerte Parte 2",
                    Genero = "Acción,Aventura".Split(','),
                    Descripcion = "Harry Potter y las Reliquias de la Muerte (parte 2), es la aventura final de la saga de Harry Potter.La película, que es un evento muy esperado, es la segunda de las dos partes",
                    Actores = "Daniel Radcliffe,Rupert Grint,Emma Watson".Split(','),
                    Anio = 2011,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Glass",
                    Genero = "Misterio,Suspenso".Split(','),
                    Descripcion = "Glass is a 2019 American superhero thriller film written, produced, and directed by M. Night Shyamalan",
                    Actores = "Samuel L. Jackson,Bruce Willis".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Capitana Marvel",
                    Genero = "Ciencia ficción,Fantasía".Split(','),
                    Descripcion = "Captain Marvel is a 2019 American superhero film based on the Marvel Comics character Carol Danvers",
                    Actores = "Samuel L. Jackson,Annette Bening".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "Toy Story 4",
                    Genero = "Comedia".Split(','),
                    Descripcion = "Toy Story 4 is an upcoming American 3D computer-animated comedy film produced by Pixar Animation Studios for Walt Disney Pictures. It is the fourth installment in the Toy Story series, and the sequel to Toy Story 3",
                    Actores = "John Ratzenberger, Jordan Peele".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            Contenido.Add(
                new Peliculas()
                {
                    Nombre = "",
                    Genero = "".Split(','),
                    Descripcion = "",
                    Actores = "".Split(','),
                    Anio = 2019,
                    Poster = "",
                });
            return Contenido;
        }
    }
}
