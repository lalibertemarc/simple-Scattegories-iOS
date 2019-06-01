// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Foundation;
using Newtonsoft.Json;
using UIKit;

namespace Scattergories
{
	public partial class Categories_Controller : UITableViewController
	{
        List<string> _allCategoriesList;
        List<string> _currentGameList;
        UIRefreshControl _refresher; 

        public Categories_Controller (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _caterogiesTitleLabel.Text = "    Categories";
            _caterogiesTitleLabel.Font = UIFont.BoldSystemFontOfSize(16.0f);

            LoadJson();
            FormCurrentCategories();

            this.TableView.Source = new CategoriesSource(_currentGameList);
            this.TableView.RegisterClassForCellReuse(typeof(CategoriesCell), CategoriesCell.Key);

            _refresher = new UIRefreshControl();
            _refresher.ValueChanged += async (sender, e) => {
                FormCurrentCategories();
                this.TableView.Source = new CategoriesSource(_currentGameList);
                this.TableView.ReloadData();
                await RefreshAsync();
            };

            this.TableView.AddSubview(_refresher);

        }

      
        async Task RefreshAsync()
        {
            _refresher.BeginRefreshing();
            _refresher.EndRefreshing();

        }

        private void FormCurrentCategories()
        {
            _currentGameList = new List<string>();
            var random = new Random();
            while(_currentGameList.Count != 12)
            {
                int index = random.Next(_allCategoriesList.Count);
                if (!_currentGameList.Contains(_allCategoriesList[index]))
                    _currentGameList.Add(_allCategoriesList[index]);  
            }
        }


        private void LoadJson()
        {
            using (StreamReader r = new StreamReader("categories.json"))
            {
                string json = r.ReadToEnd();
                _allCategoriesList = JsonConvert.DeserializeObject<List<string>>(json);
            }
        }
    }

    public class CategoriesSource : UITableViewSource
    {
        List<string> _list;

        public CategoriesSource(List<string> list)
        {
            _list = list;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            CategoriesCell cell = tableView.DequeueReusableCell(CategoriesCell.Key) as CategoriesCell;
            cell.LayoutCell($"{indexPath.Row + 1} - {_list[indexPath.Row]}");
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _list.Count;
        }
    }
}
