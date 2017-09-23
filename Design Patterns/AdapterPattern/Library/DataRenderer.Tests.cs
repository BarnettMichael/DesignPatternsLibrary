using NUnit.Framework;
using Shouldly;
using Moq;
using System.Data;
using System.IO;
using System;
using static System.Console;
using System.Linq;
using System.Data.OleDb;

namespace AdapterPattern
{
    [TestFixture]
    public class DataRendererTests
    {
        public class RenderShould
        {
            private IDbDataAdapter makeNewStubDbDataAdapter()
            {
                var stub = new Mock<IDbDataAdapter>();
                stub.Setup(a => a.Fill(It.IsAny<DataSet>()))
                    .Callback<DataSet>(ds =>
                    {

                        var dataTable = new DataTable();
                        dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                        dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                        dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

                        var dataRow = dataTable.NewRow();
                        dataRow[0] = 1;
                        dataRow[1] = "Adapter";
                        dataRow[2] = "Adapter Description";
                        dataTable.Rows.Add(dataRow);
                        ds.Tables.Add(dataTable);
                        ds.AcceptChanges();
                })
                    .Returns(1);

                return stub.Object;
            }
            [Test]
            public void WhenGivenStubDbDataAdapter_ShouldRenderASingleRow()
            {
                //Arrange
                var stubDataAdapter = makeNewStubDbDataAdapter();
                var writer = new StringWriter();
                var sut = new DataRenderer(stubDataAdapter);

                //Act
                sut.Render(writer);

                var result = writer.ToString();
                Write(result);
                //Assert
                result.Count(c => c == '\n').ShouldBe(3);
            }
        }
    }
}
