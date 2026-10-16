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

namespace Arc56.Generated.sambhavverma2004.aircargo_provenance.ShipmentState_5d60436f
{


    public class ShipmentStateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ShipmentStateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shipment_id"> </param>
        public async Task<string> CreateShipment(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 215, 77, 40 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            var result = await base.CallApp(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateShipment_Transactions(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 215, 77, 40 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shipment_id"> </param>
        /// <param name="new_state"> </param>
        public async Task<string> AdvanceShipment(string shipment_id, string new_state, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 150, 125, 38 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);
            var new_stateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_stateAbi.From(new_state);

            var result = await base.CallApp(new List<object> { abiHandle, shipment_idAbi, new_stateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AdvanceShipment_Transactions(string shipment_id, string new_state, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 150, 125, 38 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);
            var new_stateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_stateAbi.From(new_state);

            return await base.MakeTransactionList(new List<object> { abiHandle, shipment_idAbi, new_stateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2hpcG1lbnRTdGF0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfc2hpcG1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hpcG1lbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZHZhbmNlX3NoaXBtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoaXBtZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfc3RhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxMCwyNjAsMjc2LDI5MywzMTVdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHRyYW5zaXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTNdLCJlcnJvck1lc3NhZ2UiOiJTaGlwbWVudCBJRCBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjJdLCJlcnJvck1lc3NhZ2UiOiJTaGlwbWVudCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Nl0sImVycm9yTWVzc2FnZSI6IlNoaXBtZW50IGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAwXSwiZXJyb3JNZXNzYWdlIjoiU2hpcG1lbnQgaXMgYWxyZWFkeSBkZWxpdmVyZWQgb3Igc3RhdGUgaXMgaW52YWxpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMCwxNjAsMTc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3LDE2NywxODNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNUW9nSUNBZ1lubDBaV05pYkc5amF5QWljMmh3SWlBd2VEUXpOVEkwTlRReE5UUTBOVFEwSURCNE5USTBOVFF6TkRVME9UVTJORFUwTkNBd2VEUmpOR1kwTVRRME5EVTBOQ0F3ZURRME5EVTFNRFF4TlRJMU5EUTFORFFnTUhnME1UVXlOVEkwT1RVMk5EVTBOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9hWEJ0Wlc1MFgzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUZOb2FYQnRaVzUwVTNSaGRHVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXhDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaG1ZbVEzTkdReU9DQXdlRE0zT1RZM1pESTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYM05vYVhCdFpXNTBLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltRmtkbUZ1WTJWZmMyaHBjRzFsYm5Rb2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVmZjMmhwY0cxbGJuUWdZV1IyWVc1alpWOXphR2x3YldWdWRBb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV4T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMmhwY0cxbGJuUmZjM1JoZEdVdVkyOXVkSEpoWTNRdVUyaHBjRzFsYm5SVGRHRjBaUzVqY21WaGRHVmZjMmhwY0cxbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZjMmhwY0cxbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaHBjRzFsYm5SZmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdsd2JXVnVkRjl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5vYVhCdFpXNTBYMmxrTENBaVUyaHBjRzFsYm5RZ1NVUWdZMkZ1Ym05MElHSmxJR1Z0Y0hSNUlnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJUYUdsd2JXVnVkQ0JKUkNCallXNXViM1FnWW1VZ1pXMXdkSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2x3YldWdWRGOXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNd29nSUNBZ0x5OGdZWE56WlhKMElITm9hWEJ0Wlc1MFgybGtJRzV2ZENCcGJpQnpaV3htTG5Ob2FYQnRaVzUwY3l3Z0lsTm9hWEJ0Wlc1MElHRnNjbVZoWkhrZ1pYaHBjM1J6SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzJod0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTm9hWEJ0Wlc1MElHRnNjbVZoWkhrZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhwY0cxbGJuUmZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVFVLSUNBZ0lDOHZJSE5sYkdZdWMyaHBjRzFsYm5SelczTm9hWEJ0Wlc1MFgybGtYU0E5SUVKNWRHVnpLR0lpUTFKRlFWUkZSQ0lwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURRek5USTBOVFF4TlRRME5UUTBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhwY0cxbGJuUmZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURFd05UTTJPRFk1TnpBMlpEWTFObVUzTkRJd05qTTNNalkxTmpFM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emFHbHdiV1Z1ZEY5emRHRjBaUzVqYjI1MGNtRmpkQzVUYUdsd2JXVnVkRk4wWVhSbExtRmtkbUZ1WTJWZmMyaHBjRzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaSFpoYm1ObFgzTm9hWEJ0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb2FYQnRaVzUwWDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb2FYQnRaVzUwWDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCaGMzTmxjblFnYzJocGNHMWxiblJmYVdRZ2FXNGdjMlZzWmk1emFHbHdiV1Z1ZEhNc0lDSlRhR2x3YldWdWRDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5Ob2NDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCVGFHbHdiV1Z1ZENCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9hWEJ0Wlc1MFgzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qSTJDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzTjBZWFJsSUQwZ2MyVnNaaTV6YUdsd2JXVnVkSE5iYzJocGNHMWxiblJmYVdSZENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb2FYQnRaVzUwWDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCcFppQmpkWEp5Wlc1MFgzTjBZWFJsSUQwOUlFSjVkR1Z6S0dJaVExSkZRVlJGUkNJcE9nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEUXpOVEkwTlRReE5UUTBOVFEwQ2lBZ0lDQTlQUW9nSUNBZ1lub2dZV1IyWVc1alpWOXphR2x3YldWdWRGOWxiSE5sWDJKdlpIbEFNd29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaHBjRzFsYm5SZmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCdVpYZGZjM1JoZEdVZ1BUMGdVM1J5YVc1bktDSlNSVU5GU1ZaRlJDSXBMQ0FpU1c1MllXeHBaQ0IwY21GdWMybDBhVzl1SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0o1ZEdWalh6SWdMeThnSWxKRlEwVkpWa1ZFSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lIUnlZVzV6YVhScGIyNEtDbUZrZG1GdVkyVmZjMmhwY0cxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeE5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHbHdiV1Z1ZEY5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z2MyVnNaaTV6YUdsd2JXVnVkSE5iYzJocGNHMWxiblJmYVdSZElEMGdibVYzWDNOMFlYUmxMbUo1ZEdWekNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9hWEJ0Wlc1MFgzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF4TmpVek5qZzJPVGN3Tm1RMk5UWmxOelF5TURjek56UTJNVGMwTmpVeU1EYzFOekEyTkRZeE56UTJOVFkwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Ga2RtRnVZMlZmYzJocGNHMWxiblJmWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJocGNHMWxiblJmYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdWc2FXWWdZM1Z5Y21WdWRGOXpkR0YwWlNBOVBTQkNlWFJsY3loaUlsSkZRMFZKVmtWRUlpazZDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzFNalExTkRNME5UUTVOVFkwTlRRMENpQWdJQ0E5UFFvZ0lDQWdZbm9nWVdSMllXNWpaVjl6YUdsd2JXVnVkRjlsYkhObFgySnZaSGxBTlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhwY0cxbGJuUmZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVaWGRmYzNSaGRHVWdQVDBnVTNSeWFXNW5LQ0pNVDBGRVJVUWlLU3dnSWtsdWRtRnNhV1FnZEhKaGJuTnBkR2x2YmlJS0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKTVQwRkVSVVFpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2RISmhibk5wZEdsdmJnb2dJQ0FnWWlCaFpIWmhibU5sWDNOb2FYQnRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLQ21Ga2RtRnVZMlZmYzJocGNHMWxiblJmWld4elpWOWliMlI1UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJocGNHMWxiblJmYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpJS0lDQWdJQzh2SUdWc2FXWWdZM1Z5Y21WdWRGOXpkR0YwWlNBOVBTQkNlWFJsY3loaUlreFBRVVJGUkNJcE9nb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5HTTBaalF4TkRRME5UUTBDaUFnSUNBOVBRb2dJQ0FnWW5vZ1lXUjJZVzVqWlY5emFHbHdiV1Z1ZEY5bGJITmxYMkp2WkhsQU53b2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJocGNHMWxiblJmYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0J1WlhkZmMzUmhkR1VnUFQwZ1UzUnlhVzVuS0NKRVJWQkJVbFJGUkNJcExDQWlTVzUyWVd4cFpDQjBjbUZ1YzJsMGFXOXVJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1JGVUVGU1ZFVkVJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhSeVlXNXphWFJwYjI0S0lDQWdJR0lnWVdSMllXNWpaVjl6YUdsd2JXVnVkRjloWm5SbGNsOXBabDlsYkhObFFERTJDZ3BoWkhaaGJtTmxYM05vYVhCdFpXNTBYMlZzYzJWZlltOWtlVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vYVhCdFpXNTBYM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJsYkdsbUlHTjFjbkpsYm5SZmMzUmhkR1VnUFQwZ1FubDBaWE1vWWlKRVJWQkJVbFJGUkNJcE9nb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE5EUTBOVFV3TkRFMU1qVTBORFUwTkFvZ0lDQWdQVDBLSUNBZ0lHSjZJR0ZrZG1GdVkyVmZjMmhwY0cxbGJuUmZaV3h6WlY5aWIyUjVRRGtLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9hWEJ0Wlc1MFgzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYM04wWVhSbElEMDlJRk4wY21sdVp5Z2lRVkpTU1ZaRlJDSXBMQ0FpU1c1MllXeHBaQ0IwY21GdWMybDBhVzl1SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0o1ZEdWaklEVWdMeThnSWtGU1VrbFdSVVFpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2RISmhibk5wZEdsdmJnb2dJQ0FnWWlCaFpIWmhibU5sWDNOb2FYQnRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLQ21Ga2RtRnVZMlZmYzJocGNHMWxiblJmWld4elpWOWliMlI1UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJocGNHMWxiblJmYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUdWc2FXWWdZM1Z5Y21WdWRGOXpkR0YwWlNBOVBTQkNlWFJsY3loaUlrRlNVa2xXUlVRaUtUb0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzBNVFV5TlRJME9UVTJORFUwTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRhR2x3YldWdWRDQnBjeUJoYkhKbFlXUjVJR1JsYkdsMlpYSmxaQ0J2Y2lCemRHRjBaU0JwY3lCcGJuWmhiR2xrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhwY0cxbGJuUmZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVaWGRmYzNSaGRHVWdQVDBnVTNSeWFXNW5LQ0pFUlV4SlZrVlNSVVFpS1N3Z0lrbHVkbUZzYVdRZ2RISmhibk5wZEdsdmJpSUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrUkZURWxXUlZKRlJDSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0IwY21GdWMybDBhVzl1Q2lBZ0lDQmlJR0ZrZG1GdVkyVmZjMmhwY0cxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeE5nbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFJQkpnWURjMmh3QjBOU1JVRlVSVVFJVWtWRFJVbFdSVVFHVEU5QlJFVkVDRVJGVUVGU1ZFVkVCMEZTVWtsV1JVUXhHMEVBSFRFWkZFUXhHRVNDQWdUNzEwMG9CRGVXZlNZMkdnQ09BZ0FKQUVVQU1Sa1VNUmdVRUVNMkdnRkpJbGtqQ0VzQkZSSkVWd0lBU1JWRUtFeFFTYjFGQVJSRVNieElLYitBRmhVZmZIVUFFRk5vYVhCdFpXNTBJR055WldGMFpXU3dKRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1NKWkl3aExBUlVTUkZjQ0FFd29URkJIQXIxRkFVUytTRWtwRWtFQUxFaExBU29TUkVtOFNFeS9nQndWSDN4MUFCWlRhR2x3YldWdWRDQnpkR0YwWlNCMWNHUmhkR1Zrc0NSRFNTb1NRUUFKU0VzQkt4SkVRdi9MU1NzU1FRQUtTRXNCSndRU1JFTC91MGtuQkJKQkFBcElTd0VuQlJKRVF2K3FKd1VTUkVzQmdBbEVSVXhKVmtWU1JVUVNSRUwvbEE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
