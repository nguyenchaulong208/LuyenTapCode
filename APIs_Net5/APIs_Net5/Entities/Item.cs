namespace APIs_Net5.Entities
{
    public record Item
    {
        /*Mô hình dữ liệu bất biến
         * (Immutable Data Model) là một mô hình trong lập trình phần mềm mà các đối tượng dữ liệu không thể thay đổi sau khi chúng đã được tạo ra.
         * Thay vì thay đổi trạng thái của một đối tượng, mô hình này tạo ra các phiên bản mới của đối tượng mỗi khi cần thay đổi, giữ nguyên phiên bản gốc không thay đổi.

            Điều quan trọng trong mô hình dữ liệu bất biến là bất biến được áp dụng cho dữ liệu, tức là không thay đổi giá trị của đối tượng dữ liệu sau khi nó đã được tạo ra. 
            Khi có sự thay đổi, một bản sao mới sẽ được tạo ra thay vì thay đổi trực tiếp đối tượng gốc.
         * 
         */
        //Record type
        //use for immutable objects
        //With - expression support
        //value - based equality support
        //-------
        //intit - only properties: properties can only be set during initialization or in the constructor of the type that defines them.
        //Create properties for Item
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }


    }
}
