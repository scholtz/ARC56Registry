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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.IfElseExample_b287b0b6
{


    public class IfElseExampleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IfElseExampleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account_balance"> </param>
        public async Task<string> IsRich(ulong account_balance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 192, 16, 144 };
            var account_balanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); account_balanceAbi.From(account_balance);

            var result = await base.CallApp(new List<object> { abiHandle, account_balanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> IsRich_Transactions(ulong account_balance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 192, 16, 144 };
            var account_balanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); account_balanceAbi.From(account_balance);

            return await base.MakeTransactionList(new List<object> { abiHandle, account_balanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="number"> </param>
        public async Task<string> IsEven(ulong number, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 50, 194, 214 };
            var numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberAbi.From(number);

            var result = await base.CallApp(new List<object> { abiHandle, numberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> IsEven_Transactions(ulong number, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 50, 194, 214 };
            var numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberAbi.From(number);

            return await base.MakeTransactionList(new List<object> { abiHandle, numberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSWZFbHNlRXhhbXBsZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJpc19yaWNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRfYmFsYW5jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2V2ZW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnliMnhmWm14dmR5OWpiMjUwY21GamRDNXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5Qkpaa1ZzYzJWRmVHRnRjR3hsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUE1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURNM1l6QXhNRGt3SURCNE5qWXpNbU15WkRZZ0x5OGdiV1YwYUc5a0lDSnBjMTl5YVdOb0tIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW1selgyVjJaVzRvZFdsdWREWTBLWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2x6WDNKcFkyZ2dhWE5mWlhabGJnb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRRGs2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmlBdkx5QnZiaUJsY25KdmNqb2dUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVkSEp2YkY5bWJHOTNMbU52Ym5SeVlXTjBMa2xtUld4elpVVjRZVzF3YkdVdWFYTmZjbWxqYUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpYM0pwWTJnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPamN0T0FvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCSlJsOUZURk5GQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnliMnhmWm14dmR5OWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnYVdZZ1lXTmpiM1Z1ZEY5aVlXeGhibU5sSUQ0Z01UQXdNRG9LSUNBZ0lIQjFjMmhwYm5RZ01UQXdNQ0F2THlBeE1EQXdDaUFnSUNBK0NpQWdJQ0JpZWlCcGMxOXlhV05vWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlVhR2x6SUdGalkyOTFiblFnYVhNZ2NtbGphQ0VpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pVYUdseklHRmpZMjkxYm5RZ2FYTWdjbWxqYUNFaUNncHBjMTl5YVdOb1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5SeWIyeGZabXh2ZHk1amIyNTBjbUZqZEM1SlprVnNjMlZGZUdGdGNHeGxMbWx6WDNKcFkyaEFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY205c1gyWnNiM2N2WTI5dWRISmhZM1F1Y0hrNk55MDRDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRWxHWDBWTVUwVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtbHpYM0pwWTJoZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEp2YkY5bWJHOTNMMk52Ym5SeVlXTjBMbkI1T2pFeUNpQWdJQ0F2THlCbGJHbG1JR0ZqWTI5MWJuUmZZbUZzWVc1alpTQStJREV3TURvS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNREFnTHk4Z01UQXdDaUFnSUNBK0NpQWdJQ0JpZWlCcGMxOXlhV05vWDJWc2MyVmZZbTlrZVVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlVhR2x6SUdGalkyOTFiblFnYVhNZ1pHOXBibWNnZDJWc2JDNGlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlVhR2x6SUdGalkyOTFiblFnYVhNZ1pHOXBibWNnZDJWc2JDNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEp2YkY5bWJHOTNMMk52Ym5SeVlXTjBMbkI1T2pjdE9Bb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkpSbDlGVEZORkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSWdhWE5mY21samFGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1MGNtOXNYMlpzYjNjdVkyOXVkSEpoWTNRdVNXWkZiSE5sUlhoaGJYQnNaUzVwYzE5eWFXTm9RRFlLQ21selgzSnBZMmhmWld4elpWOWliMlI1UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlVhR2x6SUdGalkyOTFiblFnYVhNZ2NHOXZjaUE2S0NJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxSb2FYTWdZV05qYjNWdWRDQnBjeUJ3YjI5eUlEb29JZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5YjJ4ZlpteHZkeTlqYjI1MGNtRmpkQzV3ZVRvM0xUZ0tJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dTVVpmUlV4VFJRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmlJR2x6WDNKcFkyaGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWRISnZiRjltYkc5M0xtTnZiblJ5WVdOMExrbG1SV3h6WlVWNFlXMXdiR1V1YVhOZmNtbGphRUEyQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZiblJ5YjJ4ZlpteHZkeTVqYjI1MGNtRmpkQzVKWmtWc2MyVkZlR0Z0Y0d4bExtbHpYMlYyWlc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMTlsZG1WdU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnliMnhmWm14dmR5OWpiMjUwY21GamRDNXdlVG94T1MweU1Bb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQlVSVkpPUVZKWkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY205c1gyWnNiM2N2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtWMlpXNGlLU0JwWmlCdWRXMWlaWElnSlNBeUlEMDlJREFnWld4elpTQlRkSEpwYm1jb0lrOWtaQ0lwQ2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdKUW9nSUNBZ1ltNTZJR2x6WDJWMlpXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWMlpXNGlDZ3BwYzE5bGRtVnVYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbTlzWDJac2IzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrdE1qQUtJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dWRVZTVGtGU1dRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FYTmZaWFpsYmw5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKdmJGOW1iRzkzTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKRmRtVnVJaWtnYVdZZ2JuVnRZbVZ5SUNVZ01pQTlQU0F3SUdWc2MyVWdVM1J5YVc1bktDSlBaR1FpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pQWkdRaUNpQWdJQ0JpSUdselgyVjJaVzVmZEdWeWJtRnllVjl0WlhKblpVQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5WUJCQlVmZkhVeEcwRUFIVEVaRkVReEdFU0NBZ1Ezd0JDUUJHWXl3dFkyR2dDT0FnQUpBSDRBTVJrVU1SZ1VFRU0yR2dFWFNZSG9CdzFCQUNhQUZWUm9hWE1nWVdOamIzVnVkQ0JwY3lCeWFXTm9JVWtWRmxjR0FreFFLRXhRc0lFQlEwbUJaQTFCQUNDQUcxUm9hWE1nWVdOamIzVnVkQ0JwY3lCa2IybHVaeUIzWld4c0xrTC95b0FYVkdocGN5QmhZMk52ZFc1MElHbHpJSEJ2YjNJZ09paEMvNjQyR2dFWGdRSVlRQUFWZ0FSRmRtVnVTUlVXVndZQ1RGQW9URkN3Z1FGRGdBTlBaR1JDLytrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
