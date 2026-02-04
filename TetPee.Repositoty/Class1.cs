namespace TetPee.Repositoty;

public class Class1
{
    //ORM: object-Relational Mapping
    //Code frist và Database First
    //thông thường ở trên code mà để có thể làm việc với database,
    //thì mình cần ánh sạ (mapping) các table từ database lên code để dễ quản lí và làm việc
    
    //Database First:
    //Làm việc với database có sẵn, setup 1 db
    //oô tạo create table, create db, setup field, set các Relationship
    //sau đó ở trên code sử dụng các Driver hoặc ORM để kết nối xuống db
    // Ở trên code sẽ tạo những class tương ứng với các table trong db
    //Thằng này sử dụng khi nào: Khi mình có DB có sẵn và đã sử dụng trong rất nhiều năm rồi, những dự án Maintain
    
    //Code First:
    //Mình sẽ không setup Database thủ công bằng các Query
    //Ko vô tạo Create Table, Create db, setup field, set các Relationship
    //Mình sẽ design DB bằng những class trên code luôn, trên code setup các Entity, các Field các Relationship
    //Sau đó ánh xạ từ các class xuống các table trong DB
    //Vậy làm sao ánh xạ dưược từ các class trên code xuống DB: //ORM: object-Relational Mapping
    //Thg này sử dụng khi: Dự án mới, hiện đại, nhiều công cụ hỗ trợ
    
    //Tuyệt đỉnh ORM của .NET: Entity Framework:Ko biết sử dụng và thành thục thg này thì mất 90% sức mạnh .NET
    
}