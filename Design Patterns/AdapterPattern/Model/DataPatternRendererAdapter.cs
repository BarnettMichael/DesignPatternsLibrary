using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace AdapterPattern.Model
{
    public class DataPatternRendererAdapter : IDataPatternRendererAdapter
    {
        private DataRenderer dataRenderer;
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            var adapter = new PatternCollectionDbAdapter(patterns);
            dataRenderer = new DataRenderer(adapter);
            var writer = new StringWriter();
            dataRenderer.Render(writer);

            return writer.ToString();
        }

        internal class PatternCollectionDbAdapter : IDbDataAdapter
        {
            private IEnumerable<Pattern> patterns;
            public PatternCollectionDbAdapter(IEnumerable<Pattern> patterns) => this.patterns = patterns;

            public int Fill(DataSet dataSet)
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Description", typeof(string)));
                foreach (var pattern in patterns)
                {
                    var dataRow = dataTable.NewRow();
                    dataRow[0] = pattern.Id;
                    dataRow[1] = pattern.Name;
                    dataRow[2] = pattern.Description;
                    dataTable.Rows.Add(dataRow);
                }
                dataSet.Tables.Add(dataTable);
                dataSet.AcceptChanges();

                return dataTable.Rows.Count;
            }
            #region not implemented
            public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public ITableMappingCollection TableMappings => throw new NotImplementedException();


            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new NotImplementedException();
            }

            public IDataParameter[] GetFillParameters()
            {
                throw new NotImplementedException();
            }

            public int Update(DataSet dataSet)
            {
                throw new NotImplementedException();
            }
            #endregion
        }
    }
}
