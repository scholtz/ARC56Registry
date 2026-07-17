using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.palakaggarwal27.algorandSmartContract.GroceryList_522ad1a4
{


    public class GroceryListProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GroceryListProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="item"> </param>
        /// <param name="quantity"> </param>
        public async Task<string> AddItem(string item, string quantity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 153, 243, 234 };
            var itemAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); itemAbi.From(item);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); quantityAbi.From(quantity);

            var result = await base.CallApp(new List<object> { abiHandle, itemAbi, quantityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddItem_Transactions(string item, string quantity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 153, 243, 234 };
            var itemAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); itemAbi.From(item);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); quantityAbi.From(quantity);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemAbi, quantityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> ClearList(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 69, 57, 207 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClearList_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 69, 57, 207 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetList(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 98, 35, 134 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetList_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 98, 35, 134 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JvY2VyeUxpc3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiQWRkSXRlbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWFudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkNsZWFyTGlzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkdldExpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzcxLDk1LDExOV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0LDk4LDEyMl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjksMjE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0puY205alpYSjVUR2x6ZENJZ01IZ3hOVEZtTjJNM05TQWlJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z2EyVjVPaUFpWjNKdlkyVnllVXhwYzNRaUxBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVozSnZZMlZ5ZVV4cGMzUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QnBibWwwYVdGc1ZtRnNkV1U2SUNJaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkxUa0tJQ0FnSUM4dklHZHliMk5sY25sTWFYTjBJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0NpQWdJQ0F2THlBZ0lHdGxlVG9nSW1keWIyTmxjbmxNYVhOMElpd0tJQ0FnSUM4dklDQWdhVzVwZEdsaGJGWmhiSFZsT2lBaUlnb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkhjbTlqWlhKNVRHbHpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TUFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURWaU9UbG1NMlZoSURCNFpHSTBOVE01WTJZZ01IZ3pPRFl5TWpNNE5pQXZMeUJ0WlhSb2IyUWdJa0ZrWkVsMFpXMG9jM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSWtOc1pXRnlUR2x6ZENncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKSFpYUk1hWE4wS0NsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMEZrWkVsMFpXMWZjbTkxZEdWQU5TQnRZV2x1WDBOc1pXRnlUR2x6ZEY5eWIzVjBaVUEySUcxaGFXNWZSMlYwVEdsemRGOXliM1YwWlVBM0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1IzSnZZMlZ5ZVV4cGMzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgwZGxkRXhwYzNSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCSFpYUk1hWE4wS0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdSMlYwVEdsemRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmUTJ4bFlYSk1hWE4wWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnUTJ4bFlYSk1hWE4wS0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdRMnhsWVhKTWFYTjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5QlpHUkpkR1Z0WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnUVdSa1NYUmxiU2hwZEdWdE9pQnpkSEpwYm1jc0lIRjFZVzUwYVhSNU9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSM0p2WTJWeWVVeHBjM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QkJaR1JKZEdWdEtHbDBaVzA2SUhOMGNtbHVaeXdnY1hWaGJuUnBkSGs2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlFRmtaRWwwWlcwS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJIY205alpYSjVUR2x6ZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rZHliMk5sY25sTWFYTjBMa0ZrWkVsMFpXMG9hWFJsYlRvZ1lubDBaWE1zSUhGMVlXNTBhWFI1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2tGa1pFbDBaVzA2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnUVdSa1NYUmxiU2hwZEdWdE9pQnpkSEpwYm1jc0lIRjFZVzUwYVhSNU9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJyWlhrNklDSm5jbTlqWlhKNVRHbHpkQ0lzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaM0p2WTJWeWVVeHBjM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR052Ym5OMElHNWxkMFZ1ZEhKNUlEMGdZQ1I3YVhSbGJYMGdLQ1I3Y1hWaGJuUnBkSGw5S1N3Z1lBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlBb0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSXBMQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCMGFHbHpMbWR5YjJObGNubE1hWE4wTG5aaGJIVmxJRDBnWTNWeWNtVnVkRXhwYzNRZ0t5QnVaWGRGYm5SeWVRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QnJaWGs2SUNKbmNtOWpaWEo1VEdsemRDSXNDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5jbTlqWlhKNVRHbHpkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUIwYUdsekxtZHliMk5sY25sTWFYTjBMblpoYkhWbElEMGdZM1Z5Y21WdWRFeHBjM1FnS3lCdVpYZEZiblJ5ZVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCeVpYUjFjbTRnYVhSbGJRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlIzSnZZMlZ5ZVV4cGMzUXVRMnhsWVhKTWFYTjBLQ2tnTFQ0Z1lubDBaWE02Q2tOc1pXRnlUR2x6ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUd0bGVUb2dJbWR5YjJObGNubE1hWE4wSWl3S0lDQWdJR0o1ZEdWalh6QWdMeThnSW1keWIyTmxjbmxNYVhOMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIUm9hWE11WjNKdlkyVnllVXhwYzNRdWRtRnNkV1VnUFNBaUlnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnlaWFIxY200Z0lreHBjM1FnWTJ4bFlYSmxaQ0VpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa3hwYzNRZ1kyeGxZWEpsWkNFaUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlIzSnZZMlZ5ZVV4cGMzUXVSMlYwVEdsemRDZ3BJQzArSUdKNWRHVnpPZ3BIWlhSTWFYTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdhMlY1T2lBaVozSnZZMlZ5ZVV4cGMzUWlMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHliMk5sY25sTWFYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVuY205alpYSjVUR2x6ZEM1MllXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1Bd3RuY205alpYSjVUR2x6ZEFRVkgzeDFBREVZUUFBREtDcG5NUnRCQUhLQ0F3UmJtZlBxQk50Rk9jOEVPR0lqaGpZYUFJNERBRElBR2dBQ0kwTXhHUlJFTVJoRWlBQ0dTUlVXVndZQ1RGQXBURkN3SWtNeEdSUkVNUmhFaUFCYlNSVVdWd1lDVEZBcFRGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBaUFBWlNSVVdWd1lDVEZBcFRGQ3dJa014R1VEL3BURVlGRVFpUTRvQ0FTTW9aVVNML29BQ0lDaFFpLzlRZ0FNcExDQlFVQ2hNWjR2K2lTZ3FaNEFOVEdsemRDQmpiR1ZoY21Wa0lZa2pLR1ZFaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
