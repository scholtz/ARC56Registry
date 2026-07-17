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

namespace Arc56.Generated.Adarshkumar76.campusMarket.CampusMarketplace_36dfe96f
{


    //
    // 
    //    Marketplace contract.
    //    - The deployer is the seller
    //    - Seller lists items with prices (in microALGO)
    //    - Buyer pays ALGO to purchase items
    //    - Payment goes directly to the seller
    //    
    //
    public class CampusMarketplaceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CampusMarketplaceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Called once when the app is first created.
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///List a new item for sale.
        ///Only the seller (contract creator) can call this. Price is in microALGO (1 ALGO = 1,000,000 microALGO). Returns the assigned item_id.
        ///</summary>
        /// <param name="price"> </param>
        public async Task<ulong> ListItem(ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 227, 154, 187 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListItem_Transactions(ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 227, 154, 187 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy an item. Must be called in an atomic group with a payment txn.
        ///The payment amount must match the listed price. The payment receiver must be the seller (creator).
        ///</summary>
        /// <param name="item_id"> </param>
        /// <param name="pay_txn"> </param>
        public async Task BuyItem(PaymentTransaction pay_txn, ulong item_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 123, 43, 245, 57 };
            var item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idAbi.From(item_id);

            var result = await base.CallApp(new List<object> { abiHandle, item_idAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyItem_Transactions(PaymentTransaction pay_txn, ulong item_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 123, 43, 245, 57 };
            var item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idAbi.From(item_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, item_idAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the price of an item. Returns 0 if sold or not listed.
        ///</summary>
        /// <param name="item_id"> </param>
        public async Task<ulong> GetPrice(ulong item_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 26, 121, 239 };
            var item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idAbi.From(item_id);

            var result = await base.SimApp(new List<object> { abiHandle, item_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPrice_Transactions(ulong item_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 26, 121, 239 };
            var item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idAbi.From(item_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, item_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///How many items have been listed total.
        ///</summary>
        public async Task<ulong> GetItemCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 221, 168, 135 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetItemCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 221, 168, 135 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FtcHVzTWFya2V0cGxhY2UiLCJkZXNjIjoiXG4gICAgTWFya2V0cGxhY2UgY29udHJhY3QuXG4gICAgLSBUaGUgZGVwbG95ZXIgaXMgdGhlIHNlbGxlclxuICAgIC0gU2VsbGVyIGxpc3RzIGl0ZW1zIHdpdGggcHJpY2VzIChpbiBtaWNyb0FMR08pXG4gICAgLSBCdXllciBwYXlzIEFMR08gdG8gcHVyY2hhc2UgaXRlbXNcbiAgICAtIFBheW1lbnQgZ29lcyBkaXJlY3RseSB0byB0aGUgc2VsbGVyXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJDYWxsZWQgb25jZSB3aGVuIHRoZSBhcHAgaXMgZmlyc3QgY3JlYXRlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGlzdF9pdGVtIiwiZGVzYyI6Ikxpc3QgYSBuZXcgaXRlbSBmb3Igc2FsZS5cbk9ubHkgdGhlIHNlbGxlciAoY29udHJhY3QgY3JlYXRvcikgY2FuIGNhbGwgdGhpcy4gUHJpY2UgaXMgaW4gbWljcm9BTEdPICgxIEFMR08gPSAxLDAwMCwwMDAgbWljcm9BTEdPKS4gUmV0dXJucyB0aGUgYXNzaWduZWQgaXRlbV9pZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfaXRlbSIsImRlc2MiOiJCdXkgYW4gaXRlbS4gTXVzdCBiZSBjYWxsZWQgaW4gYW4gYXRvbWljIGdyb3VwIHdpdGggYSBwYXltZW50IHR4bi5cblRoZSBwYXltZW50IGFtb3VudCBtdXN0IG1hdGNoIHRoZSBsaXN0ZWQgcHJpY2UuIFRoZSBwYXltZW50IHJlY2VpdmVyIG11c3QgYmUgdGhlIHNlbGxlciAoY3JlYXRvcikuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ByaWNlIiwiZGVzYyI6IkdldCB0aGUgcHJpY2Ugb2YgYW4gaXRlbS4gUmV0dXJucyAwIGlmIHNvbGQgb3Igbm90IGxpc3RlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2l0ZW1fY291bnQiLCJkZXNjIjoiSG93IG1hbnkgaXRlbXMgaGF2ZSBiZWVuIGxpc3RlZCB0b3RhbC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIzLDIzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXRlbV9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByaWNlcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTAsMTUyLDIwMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NF0sImVycm9yTWVzc2FnZSI6Iml0ZW0gbm90IGF2YWlsYWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNl0sImVycm9yTWVzc2FnZSI6Im9ubHkgc2VsbGVyIGNhbiBsaXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyXSwiZXJyb3JNZXNzYWdlIjoicGF5IHRoZSBzZWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTldLCJlcnJvck1lc3NhZ2UiOiJwcmljZSBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoid3JvbmcgcGF5bWVudCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWFYUmxiVjlqYjNWdWRDSWdJbkJ5YVdObGN5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUhObGJHWXVhWFJsYlY5amIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhSbGJWOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1kyeGhjM01nUTJGdGNIVnpUV0Z5YTJWMGNHeGhZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRBS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNU5XVXpPV0ZpWWlBd2VEZGlNbUptTlRNNUlEQjRNR1V4WVRjNVpXWWdNSGhtTW1Sa1lUZzROeUF2THlCdFpYUm9iMlFnSW14cGMzUmZhWFJsYlNoMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ppZFhsZmFYUmxiU2gxYVc1ME5qUXNjR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5d2NtbGpaU2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmYVhSbGJWOWpiM1Z1ZENncGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JHbHpkRjlwZEdWdElHSjFlVjlwZEdWdElHZGxkRjl3Y21salpTQm5aWFJmYVhSbGJWOWpiM1Z1ZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFd09nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRU5oYlhCMWMwMWhjbXRsZEhCc1lXTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgzSnZkWFJsUURFeENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklITmxiR1l1YVhSbGJWOWpiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYUmxiVjlqYjNWdWRDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrTmhiWEIxYzAxaGNtdGxkSEJzWVdObExteHBjM1JmYVhSbGJWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXhwYzNSZmFYUmxiVG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSnZibXg1SUhObGJHeGxjaUJqWVc0Z2JHbHpkQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlITmxiR3hsY2lCallXNGdiR2x6ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbWxqWlM1dVlYUnBkbVVnUGlCVlNXNTBOalFvTUNrc0lDSndjbWxqWlNCdGRYTjBJR0psSUQ0Z01DSUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUhCeWFXTmxJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdjMlZzWmk1cGRHVnRYMk52ZFc1MElDczlJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBkR1Z0WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1sMFpXMWZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYUmxiVjlqYjNWdWRDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklITmxiR1l1Y0hKcFkyVnpXM05sYkdZdWFYUmxiVjlqYjNWdWRGMGdQU0J3Y21salpTNXVZWFJwZG1VS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CeWFXTmxjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVEyRnRjSFZ6VFdGeWEyVjBjR3hoWTJVdVluVjVYMmwwWlcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlkWGxmYVhSbGJUb0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdjSEpwWTJVZ1BTQnpaV3htTG5CeWFXTmxjMXRwZEdWdFgybGtMbTVoZEdsMlpWMEtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQnlhV05sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbWxqWlhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCeWFXTmxJRDRnVlVsdWREWTBLREFwTENBaWFYUmxiU0J1YjNRZ1lYWmhhV3hoWW14bElnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnYVhSbGJTQnViM1FnWVhaaGFXeGhZbXhsQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVjkwZUc0dWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0luQmhlU0IwYUdVZ2MyVnNiR1Z5SWdvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1SUhSb1pTQnpaV3hzWlhJS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1WDNSNGJpNWhiVzkxYm5RZ1BUMGdjSEpwWTJVc0lDSjNjbTl1WnlCd1lYbHRaVzUwSUdGdGIzVnVkQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSGR5YjI1bklIQmhlVzFsYm5RZ1lXMXZkVzUwQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzNNeTAzTkFvZ0lDQWdMeThnSXlCdFlYSnJJR0Z6SUhOdmJHUWdLSE5sZENCd2NtbGpaU0IwYnlBd0tRb2dJQ0FnTHk4Z2MyVnNaaTV3Y21salpYTmJhWFJsYlY5cFpDNXVZWFJwZG1WZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1F1UTJGdGNIVnpUV0Z5YTJWMGNHeGhZMlV1WjJWMFgzQnlhV05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM0J5YVdObE9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklIQnlhV05sTENCZlpYaHBjM1J6SUQwZ2MyVnNaaTV3Y21salpYTXViV0Y1WW1Vb2FYUmxiVjlwWkM1dVlYUnBkbVVwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y21salpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJwWmlCZlpYaHBjM1J6T2dvZ0lDQWdZbm9nWjJWMFgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHdjbWxqWlNrS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvS1oyVjBYM0J5YVdObFgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1F1UTJGdGNIVnpUV0Z5YTJWMGNHeGhZMlV1WjJWMFgzQnlhV05sUURRNkNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG8zTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZmNISnBZMlZmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRDNURZVzF3ZFhOTllYSnJaWFJ3YkdGalpTNW5aWFJmY0hKcFkyVkFOQW9LQ2k4dklHTnZiblJ5WVdOMExrTmhiWEIxYzAxaGNtdGxkSEJzWVdObExtZGxkRjlwZEdWdFgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMmwwWlcxZlkyOTFiblE2Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLSE5sYkdZdWFYUmxiVjlqYjNWdWRDa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcGRHVnRYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWwwWlcxZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQUlKZ01LYVhSbGJWOWpiM1Z1ZEFad2NtbGpaWE1FRlI5OGRURVlRQUFES0NObk1Sa1VSREVZUVFBa2dnUUVsZU9hdXdSN0svVTVCQTRhZWU4RTh0Mm9oellhQUk0RUFCUUFQZ0J2QUpnQWdBUk1YR0c2TmhvQWpnRUFBUUFvSTJjaVF6WWFBVWtWSkJKRU1RQXlDUkpFRjBsRUl5aGxSQ0lJS0VzQlp4WXBTd0ZRVHdJV3Z5cE1VTEFpUXpZYUFVa1ZKQkpFTVJZaUNVazRFQ0lTUkV3WEZpbE1VRW0rUkJkSlJFc0NPQWN5Q1JKRVR3STRDQkpFSXhhL0lrTTJHZ0ZKRlNRU1JCY1dLVXhRdmt3WFRFRUFDRWtXS2t4UXNDSkRnQWdBQUFBQUFBQUFBRUwvN1NNb1pVUVdLa3hRc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
