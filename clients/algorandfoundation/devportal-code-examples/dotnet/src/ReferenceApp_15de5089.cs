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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceApp_15de5089
{


    //
    // A contract that demonstrates how to use resource usage in a contract using an asset reference
    //
    public class ReferenceAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Calls the increment method on another Counter app with a hardcoded app ID
        ///</summary>
        public async Task<ulong> IncrementViaInner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 7, 174, 150 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementViaInner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 7, 174, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calls the increment method on another Counter app passed as an argument
        ///</summary>
        /// <param name="app">The application to call </param>
        public async Task<ulong> IncrementViaInnerWithArg(ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 144, 74, 145 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementViaInnerWithArg_Transactions(ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 144, 74, 145 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQXBwIiwiZGVzYyI6IkEgY29udHJhY3QgdGhhdCBkZW1vbnN0cmF0ZXMgaG93IHRvIHVzZSByZXNvdXJjZSB1c2FnZSBpbiBhIGNvbnRyYWN0IHVzaW5nIGFuIGFzc2V0IHJlZmVyZW5jZSIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbmNyZW1lbnRWaWFJbm5lciIsImRlc2MiOiJDYWxscyB0aGUgaW5jcmVtZW50IG1ldGhvZCBvbiBhbm90aGVyIENvdW50ZXIgYXBwIHdpdGggYSBoYXJkY29kZWQgYXBwIElEIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBpbmNyZW1lbnRlZCBjb3VudGVyIHZhbHVlIGZyb20gdGhlIGlubmVyIGNhbGwifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRWaWFJbm5lcldpdGhBcmciLCJkZXNjIjoiQ2FsbHMgdGhlIGluY3JlbWVudCBtZXRob2Qgb24gYW5vdGhlciBDb3VudGVyIGFwcCBwYXNzZWQgYXMgYW4gYXJndW1lbnQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6IlRoZSBhcHBsaWNhdGlvbiB0byBjYWxsIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBpbmNyZW1lbnRlZCBjb3VudGVyIHZhbHVlIGZyb20gdGhlIGlubmVyIGNhbGwifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg4LDEyNF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dOaUF3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBd2VEUmhNekkxT1RBeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmtaV1poZFd4MElHTnNZWE56SUZKbFptVnlaVzVqWlVGd2NDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUE1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURrME1EZGhaVGsySURCNFpXTTVNRFJoT1RFZ0x5OGdiV1YwYUc5a0lDSnBibU55WlcxbGJuUldhV0ZKYm01bGNpZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSnBibU55WlcxbGJuUldhV0ZKYm01bGNsZHBkR2hCY21jb2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdsdVkzSmxiV1Z1ZEZacFlVbHVibVZ5SUdsdVkzSmxiV1Z1ZEZacFlVbHVibVZ5VjJsMGFFRnlad29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCU1pXWmxjbVZ1WTJWQmNIQWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliaUF2THlCdmJpQmxjbkp2Y2pvZ1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tDZ292THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEpsWm1WeVpXNWpaVUZ3Y0M1cGJtTnlaVzFsYm5SV2FXRkpibTVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVZM0psYldWdWRGWnBZVWx1Ym1WeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16TFRRd0NpQWdJQ0F2THlCamIyNXpkQ0JoY0hCRFlXeHNWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nWVhCd0xtbGtMQW9nSUNBZ0x5OGdJQ0FnSUM4dklGVnpaU0J0WlhSb2IyUlRaV3hsWTNSdmNpQjBieUJuWlhRZ2RHaGxJRUZDU1NCelpXeGxZM1J2Y2lCbWIzSWdkR2hsSUdsdVkzSmxiV1Z1ZENCdFpYUm9iMlFLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYllYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ25hVzVqY21WdFpXNTBLQ2wxYVc1ME5qUW5LVjBzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjJsdVkzSmxiV1Z1ZENncGRXbHVkRFkwSnlsZExBb2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSW1sdVkzSmxiV1Z1ZENncGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3SUQwZ1FYQndiR2xqWVhScGIyNG9NVGN4TnlrZ0x5OGdVbVZ3YkdGalpTQjNhWFJvSUhsdmRYSWdZWEJ3YkdsallYUnBiMjRnYVdRS0lDQWdJSEIxYzJocGJuUWdNVGN4TnlBdkx5QXhOekUzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNeTB6T1FvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3UTJGc2JGUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd1NXUTZJR0Z3Y0M1cFpDd0tJQ0FnSUM4dklDQWdJQ0F2THlCVmMyVWdiV1YwYUc5a1UyVnNaV04wYjNJZ2RHOGdaMlYwSUhSb1pTQkJRa2tnYzJWc1pXTjBiM0lnWm05eUlIUm9aU0JwYm1OeVpXMWxiblFnYldWMGFHOWtDaUFnSUNBdkx5QWdJQ0FnWVhCd1FYSm5jem9nVzJGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0oybHVZM0psYldWdWRDZ3BkV2x1ZERZMEp5bGRMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekxUUXdDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkRZV3hzVkhodUlEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJKWkRvZ1lYQndMbWxrTEFvZ0lDQWdMeThnSUNBZ0lDOHZJRlZ6WlNCdFpYUm9iMlJUWld4bFkzUnZjaUIwYnlCblpYUWdkR2hsSUVGQ1NTQnpaV3hsWTNSdmNpQm1iM0lnZEdobElHbHVZM0psYldWdWRDQnRaWFJvYjJRS0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWduYVc1amNtVnRaVzUwS0NsMWFXNTBOalFuS1Ywc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVpHVmpiMlJsUVhKak5EeDFhVzUwTmpRK0tHRndjRU5oYkd4VWVHNHViR0Z6ZEV4dlp5d2dKMnh2WnljcENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x1WTNKbGJXVnVkRlpwWVVsdWJtVnlLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwU1pXWmxjbVZ1WTJWQmNIQXVhVzVqY21WdFpXNTBWbWxoU1c1dVpYSlhhWFJvUVhKblczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVqY21WdFpXNTBWbWxoU1c1dVpYSlhhWFJvUVhKbk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVqY21WdFpXNTBWbWxoU1c1dVpYSlhhWFJvUVhKbktHRndjRG9nUVhCd2JHbGpZWFJwYjI0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwTFRZeENpQWdJQ0F2THlCamIyNXpkQ0JoY0hCRFlXeHNWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nWVhCd0xtbGtMQW9nSUNBZ0x5OGdJQ0FnSUM4dklGVnpaU0J0WlhSb2IyUlRaV3hsWTNSdmNpQjBieUJuWlhRZ2RHaGxJRUZDU1NCelpXeGxZM1J2Y2lCbWIzSWdkR2hsSUdsdVkzSmxiV1Z1ZENCdFpYUm9iMlFLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYllYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ25hVzVqY21WdFpXNTBLQ2wxYVc1ME5qUW5LVjBzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjJsdVkzSmxiV1Z1ZENncGRXbHVkRFkwSnlsZExBb2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSW1sdVkzSmxiV1Z1ZENncGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMExUWXdDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkRZV3hzVkhodUlEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJKWkRvZ1lYQndMbWxrTEFvZ0lDQWdMeThnSUNBZ0lDOHZJRlZ6WlNCdFpYUm9iMlJUWld4bFkzUnZjaUIwYnlCblpYUWdkR2hsSUVGQ1NTQnpaV3hsWTNSdmNpQm1iM0lnZEdobElHbHVZM0psYldWdWRDQnRaWFJvYjJRS0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWduYVc1amNtVnRaVzUwS0NsMWFXNTBOalFuS1Ywc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFF0TmpFS0lDQWdJQzh2SUdOdmJuTjBJR0Z3Y0VOaGJHeFVlRzRnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NFbGtPaUJoY0hBdWFXUXNDaUFnSUNBdkx5QWdJQ0FnTHk4Z1ZYTmxJRzFsZEdodlpGTmxiR1ZqZEc5eUlIUnZJR2RsZENCMGFHVWdRVUpKSUhObGJHVmpkRzl5SUdadmNpQjBhR1VnYVc1amNtVnRaVzUwSUcxbGRHaHZaQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0aGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZHBibU55WlcxbGJuUW9LWFZwYm5RMk5DY3BYU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVrWldOdlpHVkJjbU0wUEhWcGJuUTJORDRvWVhCd1EyRnNiRlI0Ymk1c1lYTjBURzluTENBbmJHOW5KeWtLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNWpjbVZ0Wlc1MFZtbGhTVzV1WlhKWGFYUm9RWEpuS0dGd2NEb2dRWEJ3YkdsallYUnBiMjRwT2lCMWFXNTBOalFnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREJnQUJKZ0lFRlI5OGRRUktNbGtCTVJ0QkFCMHhHUlJFTVJoRWdnSUVsQWV1bGdUc2tFcVJOaG9BamdJQUNRQXNBREVaRkRFWUZCQkRzU215R29HMURiSVlJcklRSTdJQnM3UStTVmNFQUV4WEFBUW9Fa1FvVEZDd0pFTTJHZ0VYc1NteUdySVlJcklRSTdJQnM3UStTVmNFQUV4WEFBUW9Fa1FvVEZDd0pFTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
