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

namespace Arc56.Generated.algorandfoundation.puya.DebugContract_48a2de01
{


    public class DebugContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DebugContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        /// <param name="y"> </param>
        /// <param name="z"> </param>
        public async Task<ulong> Test(ulong x, ulong y, ulong z, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 87, 75, 255 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);
            var yAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yAbi.From(y);
            var zAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); zAbi.From(z);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi, yAbi, zAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(ulong x, ulong y, ulong z, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 87, 75, 255 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);
            var yAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yAbi.From(y);
            var zAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); zAbi.From(z);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi, yAbi, zAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVidWdDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InoiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0NSwxNTQsMTY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeE1DQXhJRGdnVkUxUVRGOUJYMDFWVEZRS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnek1ETXhNekl6TXpNME16VXpOak0zTXpnek9TQWlJQ0lLSUNBZ0lDOHZJR1JsWW5WbkwyTnZiblJ5WVdOMExuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklFUmxZblZuUTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5UTTFOelJpWm1ZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRGOXliM1YwWlVBek9nb2dJQ0FnTHk4Z1pHVmlkV2N2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCMFpYTjBDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURVNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVpHVmlkV2N1WTI5dWRISmhZM1F1YzI5dFpWOW1kVzVqS0dFNklIVnBiblEyTkN3Z1lqb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbk52YldWZlpuVnVZem9LSUNBZ0lDOHZJR1JsWW5WbkwyTnZiblJ5WVdOMExuQjVPalF4TFRReUNpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JSE52YldWZlpuVnVZeWhoT2lCVlNXNTBOalFzSUdJNklGVkpiblEyTkNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnWVNBclBTQmlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdMeThnWkdWaWRXY3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUdJZ0tqMGdZUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRFS0lDQWdJQzh2SUdSbFluVm5MMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCaElDczlJR0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJQzh2SUdSbFluVm5MMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCaElDbzlJRElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS2dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB5Q2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnZUNBOUlHRWdLeUJpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUM4dklHUmxZblZuTDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QjVJRDBnWVNBcUlHSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnY21WMGRYSnVJSGdnYVdZZ2VDQThJSGtnWld4elpTQjVDaUFnSUNCa2RYQXlDaUFnSUNBOENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WkdWaWRXY3VZMjl1ZEhKaFkzUXVhWFJ2WVNocE9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHBkRzloT2dvZ0lDQWdMeThnWkdWaWRXY3ZZMjl1ZEhKaFkzUXVjSGs2TlRJdE5UTUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnYVhSdllTaHBPaUJWU1c1ME5qUXBJQzArSUVKNWRHVnpPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z2FXWWdhU0E4SUhKaFpHbDRPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdkx5QmtaV0oxWnk5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdjbUZrYVhnZ1BTQmthV2RwZEhNdWJHVnVaM1JvQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNVEFLSUNBZ0lDOHZJR1JsWW5WbkwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJwWmlCcElEd2djbUZrYVhnNkNpQWdJQ0E4Q2lBZ0lDQmllaUJwZEc5aFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWkdWaWRXY3ZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdScFoybDBjeUE5SUVKNWRHVnpLR0lpTURFeU16UTFOamM0T1NJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QXpNVE15TXpNek5ETTFNell6TnpNNE16a0tJQ0FnSUM4dklHUmxZblZuTDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QnlaWFIxY200Z1pHbG5hWFJ6VzJsZENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21WMGMzVmlDZ3BwZEc5aFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdSbFluVm5MMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCeVpYUjFjbTRnYVhSdllTaHBJQzh2SUhKaFpHbDRLU0FySUdScFoybDBjMXRwSUNVZ2NtRmthWGhkQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDOHZJR1JsWW5WbkwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJ5WVdScGVDQTlJR1JwWjJsMGN5NXNaVzVuZEdnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4TUFvZ0lDQWdMeThnWkdWaWRXY3ZZMjl1ZEhKaFkzUXVjSGs2TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJwZEc5aEtHa2dMeThnY21Ga2FYZ3BJQ3NnWkdsbmFYUnpXMmtnSlNCeVlXUnBlRjBLSUNBZ0lDOEtJQ0FnSUdOaGJHeHpkV0lnYVhSdllRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z2NtRmthWGdnUFNCa2FXZHBkSE11YkdWdVozUm9DaUFnSUNCcGJuUmpYekFnTHk4Z01UQUtJQ0FnSUM4dklHUmxZblZuTDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QnlaWFIxY200Z2FYUnZZU2hwSUM4dklISmhaR2w0S1NBcklHUnBaMmwwYzF0cElDVWdjbUZrYVhoZENpQWdJQ0FsQ2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnWkdsbmFYUnpJRDBnUW5sMFpYTW9ZaUl3TVRJek5EVTJOemc1SWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1ETXhNekl6TXpNME16VXpOak0zTXpnek9Rb2dJQ0FnTHk4Z1pHVmlkV2N2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCcGRHOWhLR2tnTHk4Z2NtRmthWGdwSUNzZ1pHbG5hWFJ6VzJrZ0pTQnlZV1JwZUYwS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbVJsWW5WbkxtTnZiblJ5WVdOMExrUmxZblZuUTI5dWRISmhZM1F1ZEdWemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNRNkNpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRvM0NpQWdJQ0F2THlCaElEMGdlQ0FxSUZSbGJYQnNZWFJsVm1GeVcxVkpiblEyTkYwb0lrRmZUVlZNVkNJcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SUZSTlVFeGZRVjlOVlV4VUNpQWdJQ0FxQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRvNENpQWdJQ0F2THlCaUlEMGdlQ0FySUhrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z1pHVmlkV2N2WTI5dWRISmhZM1F1Y0hrNk9Rb2dJQ0FnTHk4Z1l5QTlJR0lnS2lCNkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0tnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QmtaV0oxWnk5amIyNTBjbUZqZEM1d2VUb3hNQW9nSUNBZ0x5OGdhV1lnWWlBOElHTTZDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMlZzYzJWZlltOWtlVUF6Q2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWVNBOUlHRWdLeUI1Q2lBZ0lDQmthV2NnTXdvZ0lDQWdLd29LZEdWemRGOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z1pHVmlkV2N2WTI5dWRISmhZM1F1Y0hrNk1Ua0tJQ0FnSUM4dklHbG1JR0VnS3lCaUlEd2dZem9LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5bGJITmxYMkp2WkhsQU1UUUtJQ0FnSUM4dklHUmxZblZuTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmhJQ285SUhOdmJXVmZablZ1WXloaExDQjVLUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdjMjl0WlY5bWRXNWpDaUFnSUNBcUNncDBaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFU2Q2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnWW1WbElEMGdhWFJ2WVNoaUtRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJwZEc5aENpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QmtaV0oxWnk5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdZeUE5SUdFZ0t5QmlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdMeThnWkdWaWRXY3ZZMjl1ZEhKaFkzUXVjSGs2TWpZS0lDQWdJQzh2SUdObFlTQTlJR2wwYjJFb1l5a0tJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJwZEc5aENpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QmtaV0oxWnk5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdhV1lnWVNBOElHTTZDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tJQ0FnSUM4dklHUmxZblZuTDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QmhJQ3M5SUdNS0lDQWdJR1JwWnlBekNpQWdJQ0FyQ2dwMFpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNBdkx5QmtaV0oxWnk5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdhV1lnWVNBOElHSTZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU1Ua0tJQ0FnSUM4dklHUmxZblZuTDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QmhJQ3M5SUdJS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2dwMFpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU1UazZDaUFnSUNBdkx5QmtaV0oxWnk5amIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdhV1lnWVNBOElHSWdLeUJqT2dvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZbm9nZEdWemRGOWhablJsY2w5cFpsOWxiSE5sUURJeENpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRvek13b2dJQ0FnTHk4Z1lTQTlJR0VnS2lCNkNpQWdJQ0JrYVdjZ013b2dJQ0FnS2dvS2RHVnpkRjloWm5SbGNsOXBabDlsYkhObFFESXhPZ29nSUNBZ0x5OGdaR1ZpZFdjdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJR0Y1WlNBOUlHbDBiMkVvWVNrS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQnBkRzloQ2lBZ0lDQXZMeUJrWldKMVp5OWpiMjUwY21GamRDNXdlVG96TmdvZ0lDQWdMeThnYkc5bktHRjVaU3dnWW1WbExDQmpaV0VzSUhObGNEMGlJQ0lwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnWkdWaWRXY3ZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblJsYzNSZlpXeHpaVjlpYjJSNVFERTBPZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUdSbFluVm5MMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCaUlDbzlJSE52YldWZlpuVnVZeWhpTENCNktRb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJ6YjIxbFgyWjFibU1LSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUdJZ2RHVnpkRjloWm5SbGNsOXBabDlsYkhObFFERTFDZ3AwWlhOMFgyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ0x5OGdaR1ZpZFdjdlkyOXVkSEpoWTNRdWNIazZNVElLSUNBZ0lDOHZJR1ZzYVdZZ1lTQThJR002Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJWc2MyVmZZbTlrZVVBMUNpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRveE13b2dJQ0FnTHk4Z1lTQTlJR0VnS3lCNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnS3dvZ0lDQWdZaUIwWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NuUmxjM1JmWld4elpWOWliMlI1UURVNkNpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1pXeHBaaUJpSUR3Z1lUb0tJQ0FnSUdSMWNESUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUmZaV3h6WlY5aWIyUjVRRGNLSUNBZ0lDOHZJR1JsWW5WbkwyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJoSUQwZ1lTQXFJRE1LSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnS2dvZ0lDQWdZaUIwWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NuUmxjM1JmWld4elpWOWliMlI1UURjNkNpQWdJQ0F2THlCa1pXSjFaeTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1pXeHBaaUJpSUQ0Z1lUb0tJQ0FnSUdSMWNESUtJQ0FnSUQ0S0lDQWdJR0o2SUhSbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnTHk4Z1pHVmlkV2N2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHSWdQU0JpSUNzZ1lRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR0lnZEdWemRGOWhablJsY2w5cFpsOWxiSE5sUURFeUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQ2dFSUFTWUNDakF4TWpNME5UWTNPRGtCSURFYlFRQVlnQVJUVjB2L05ob0FqZ0VBQVFBeEdSUXhHQkJFUWdCWE1Sa1VNUmdVRUVPS0FnR0wvb3YvQ0l6K2kvK0wvZ3VNLzR2K2kvOElTWXorZ1FJTFNZeitpLzhJaS82TC93dEtERXhPQWsySmlnRUJpLzhpREVFQUJpaUwveU5ZaVl2L0lncUkvK21ML3lJWUtFd2pXRkNKTmhvQlNSVWtFa1FYTmhvQ1NSVWtFa1FYU1U0Q05ob0RTUlVrRWtRWFNVNEVTd0lsQzA0RFRnSUlTVTREU1U4Q0MwbE9CQXhCQUhOTEF3aEpTd0lJVHdNTVFRQlhTVThEaVA5bUMwc0JTWWovalU0RFN3RkpUd0lJU1U0RVNZai9mazRFREVFQUEwc0RDRWxMQWd4QkFBTkxBUWhNVHdNSVN3RU5RUUFEU3dNTFNZai9XaWxRVHdOUUtWQlBBbEN3Rm9BRUZSOThkVXhRc0NORFR3SklURWxMQTRqL0N3dE1RditoU1VzRERFRUFCa3NFQ0VML2cwb01RUUFHZ1FNTFF2OTRTZzFCLzNOTVN3RUlURUwvYXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IkFfTVVMVCI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOiJBQUFBQUFBQUFBRT0ifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
