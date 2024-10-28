using Academy.API.Models;

namespace TestApi;

public static class Data
{
    public static List<Student> students;
    public static List<Book> books;
    static Data()
    {
        students = [
          new Student{
              Id = 1,
              Name = "Musa",
              Age = 25
          },
         new Student{
              Id = 2,
              Name = "Aslan",
              Age = 20
          },
         new Student{
              Id = 1,
              Name = "Rizvan",
              Age = 22
          },
         new Student{
              Id = 1,
              Name = "Aqil",
              Age = 21
          }
        ];

        books = [
            new Book{
                id = 1,
                Name = "Book1",
                Author = "Author1"
            },
            new Book{
                id = 2,
                Name = "Book2",
                Author = "Author2"
            },
            new Book{
                id = 3,
                Name = "Book3",
                Author = "Author3"
            },
            ];
    }

}