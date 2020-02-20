using System;
using System.IO;
using Microsoft.AspNetCore.Http;
namespace Microsoft.AspNetCore.Http
{
    public static class AbpFormFileExtensions
    {
        // public static List<TEntity> MapTo<TEntity>(this IFormFile file, Func<ExcelWorksheet, List<TEntity>> mapper)
        // {

            // if (file == null || file.Length <= 0)
            // {
            //     throw new ArgumentNullException("File not null");
            // }

            // if (
            //     new[] { ".xlsx", ".xls" }.All(ext => !Path.GetExtension(formFile.FileName)
            //     .Equals(ext, StringComparison.OrdinalIgnoreCase))
            // )
            // {
            //     throw new ArgumentNullException("Not support file Extension");
            // }


            // using (var stream = new MemoryStream())
            // {
            //     await formFile.CopyToAsync(stream, cancellationToken);

            //     using (var package = new ExcelPackage(stream))
            //     {
            //         ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            //         var rowCount = worksheet.Dimension.Rows;

            //         return mapper(worksheet);
            //     }
            // }
        // }
    }
}
