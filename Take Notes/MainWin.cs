using System.Data;
using System.Windows.Forms;

namespace Take_Notes
{
    public partial class MainWin : Form
    {


        /// <summary>
        /// This table is used to store notes
        /// </summary>
        private DataTable dataStore = new DataTable();


        // Constructor
        public MainWin()
        {
            InitializeComponent();

            // Add columns to data store
            dataStore.Columns.Add( "Title" , typeof( string ) );
            dataStore.Columns.Add( "Desc" , typeof( string ) );
            
            // Bind data store to view. Updating data store updates the Data View Control
            CDataView_DGVIEW.DataSource = dataStore;
            CDataView_DGVIEW.Columns[ 1 ].Visible = false;
            CDataView_DGVIEW.Columns[ 0 ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        // Save Button - Click
        private void CSave_BTN_Click( object sender , System.EventArgs e )
        {

            // Check if a title is provided
            if (string.IsNullOrWhiteSpace( CTitle_TXT.Text))
            {
                MessageBox.Show( "Please provide a title" );
                return;
            }

            // Add row to data store
            dataStore.Rows.Add( new object[] { CTitle_TXT.Text , CDescription_TXT.Text } );

        }


        // Read Button - Click
        private void CRead_BTN_Click( object sender , System.EventArgs e )
        {

            // Check if rows are selected
            if(CDataView_DGVIEW.SelectedRows.Count == 0)
            {
                MessageBox.Show( "Please select a row" );
                return;
            }

            // Get selected row
            var row = CDataView_DGVIEW.SelectedRows[ 0 ];

            // Load row data into textboxes
            CTitle_TXT.Text = row.Cells[ 0 ].Value.ToString();
            CDescription_TXT.Text = row.Cells[ 1 ].Value.ToString();

        }


        // Delete Button - Click
        private void CDelete_BTN_Click( object sender , System.EventArgs e )
        {

            // Check if rows are selected
            if ( CDataView_DGVIEW.SelectedRows.Count == 0 )
            {
                MessageBox.Show( "Please select a row" );
                return;
            }

            // Get selected row
            var row = CDataView_DGVIEW.SelectedRows[ 0 ];
            // Remove row
            CDataView_DGVIEW.Rows.Remove( row );

        }


    }
}
