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

namespace Arc56.Generated.akita_protocol.akita_sc.PaySiloFactoryPlugin_528c461c
{


    public class PaySiloFactoryPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PaySiloFactoryPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="recipient"> </param>
        public async Task<ulong> Mint(ulong wallet, bool rekeyBack, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 155, 108, 94 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Mint_Transactions(ulong wallet, bool rekeyBack, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 155, 108, 94 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGF5U2lsb0ZhY3RvcnlQbHVnaW4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoibWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ4NF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5d1lYa3RjMmxzYnk5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFZWGxUYVd4dlJtRmpkRzl5ZVZCc2RXZHBiaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1pEbGlObU0xWlNBdkx5QnRaWFJvYjJRZ0ltMXBiblFvZFdsdWREWTBMR0p2YjJ3c1lXUmtjbVZ6Y3lsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMjFwYm5SZmNtOTFkR1ZBTXdvZ0lDQWdaWEp5Q2dwdFlXbHVYMjFwYm5SZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzQmhlUzF6YVd4dkwyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE55MHlNUW9nSUNBZ0x5OGdiV2x1ZENnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdjbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0J5WldOcGNHbGxiblE2SUVGalkyOTFiblFLSUNBZ0lDOHZJQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCdGFXNTBDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZjR0Y1TFhOcGJHOHZabUZqZEc5eWVTNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUdGNVUybHNiMFpoWTNSdmNubFFiSFZuYVc0Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzQmhlUzF6YVd4dkwyWmhZM1J2Y25rdVlXeG5ieTUwY3pvNlVHRjVVMmxzYjBaaFkzUnZjbmxRYkhWbmFXNHViV2x1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMXBiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5d1lYa3RjMmxzYnk5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRjdE1qRUtJQ0FnSUM4dklHMXBiblFvQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdjbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBDaUFnSUNBdkx5QXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNamcyTFRJNE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNOd1pXNWthVzVuUVdSa2NtVnpjMEo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lFSjVkR1Z6S0VGaWMzUnlZV04wUVdOamIzVnVkRWRzYjJKaGJGTjBZWFJsUzJWNWMxTndaVzVrYVc1blFXUmtjbVZ6Y3lrS0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpnNENpQWdJQ0F2THlCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk53Wlc1a2FXNW5YMkZrWkhKbGMzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSTROaTB5T0RrS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXdZWGt0YzJsc2J5OW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1qWXRNekFLSUNBZ0lDOHZJR052Ym5OMElISmxjM1ZzZENBOUlIQmhlVk5wYkc4dVkyRnNiQzVqY21WaGRHVW9ld29nSUNBZ0x5OGdJQ0J6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdHlaV05wY0dsbGJuUmRMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcENpQWdJQ0F2THlCOUtRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem96TkRJS0lDQWdJQzh2SUdsbUlDZ2hjbVZyWlhsQ1lXTnJLU0I3Q2lBZ0lDQmlibm9nYldsdWRGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TXpRekNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtDbTFwYm5SZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPanB5Wld0bGVVRmtaSEpsYzNOQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM0JoZVMxemFXeHZMMlpoWTNSdmNua3VZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdZMjl1YzNRZ2NHRjVVMmxzYnlBOUlHTnZiWEJwYkdWQmNtTTBLRkJoZVZOcGJHOVFiSFZuYVc0cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JGZUhSeVlWQnliMmR5WVcxUVlXZGxjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RHOWpZV3hPZFcxVmFXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCTWIyTmhiRTUxYlVKNWRHVlRiR2xqWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSMnh2WW1Gc1RuVnRRbmwwWlZOc2FXTmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCSGJHOWlZV3hPZFcxVmFXNTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVFkwS0VNMFJVSlJkejA5S1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYkdWaGNsTjBZWFJsVUhKdlozSmhiVkJoWjJWekNpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUWTBLRU41UVVWQlFVVlJRME5aUWtOWVNteFpNbXgzWVZkV2RXUkVSVnBHUlZGNFIwVkZRVVJ2UVVVMFJXUlRXV3BaWVVGSk5FSkJRelJCWjBGVVRXRlZObkZPYUc5QmFtZEZRVVZuUTB0QlowZE1MMnRCUVVGNlNVUnBXWFl2WTJkb1JXbFVXV0ZCVld0V1oxTkJVMUpEYUUxYWVVNUVTV3R0UVVGRmF6SkhaMFpLUmxOVlUxSkNaRXBPYUc5RFUxSlZha1ZyVVdsVk1IY3lSMmRPU2xSblNrcEpiR3hLVkdkTmEwTTBSVU5EUlhkV1JXdFRRVVZJVG5kYVZ6VnJZVmMxYmxneVJtdGFTRXBzWXpOT2JGTkRTa3BUZDAxTlVWRkRVVk4zVGxoQlowSk1RVk5SVEVwR2FFcEpiSFJLVkdkS1JrTlRWbUpTVVd4QlFVUjFlRWxwYUd4VVJWVk1Va1Z6UTBsM2JFeEJVVEZDUVVJNGVVRTNTV2RUZDJWNVEwVnpTbk5uWkV4QllrbEJTVGRKVVVseVNVSnpNR3RxUTBWVlFsRjJLM1ZUZDFKTVFtOXFMMUpGVEM4eVlrVnBTMGRXVFZKUmNFVlRkMGxxUTFWelFrUlZSVUZJZWtsRWMybENURUp5U1ZKVGQyVjVSV3R6U1hOb1VreEJZa2xCWjFGVGVVVkRTM2xCWWs1REx6Y3hURUpGYzBkcFVEaEtVWFl2V2trd1RUMHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlZCaFoyVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl3WVhrdGMybHNieTltWVdOMGIzSjVMbUZzWjI4dWRITTZNall0TXpBS0lDQWdJQzh2SUdOdmJuTjBJSEpsYzNWc2RDQTlJSEJoZVZOcGJHOHVZMkZzYkM1amNtVmhkR1VvZXdvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR5WldOcGNHbGxiblJkTEFvZ0lDQWdMeThnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNBdkx5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxhMlY1Vkc4S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmpOamswWldGaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5d1lYa3RjMmxzYnk5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRjdE1qRUtJQ0FnSUM4dklHMXBiblFvQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdjbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBDaUFnSUNBdkx5QXBPaUIxYVc1ME5qUWdld29nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0YVc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TXpRMkNpQWdJQ0F2THlCeVpYUjFjbTRnZDJGc2JHVjBMbUZrWkhKbGMzTUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl3WVhrdGMybHNieTltWVdOMGIzSjVMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJR0lnYldsdWRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02T25KbGEyVjVRV1JrY21WemMwQTJDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRXhHMEVBR0lBRURadHNYallhQUk0QkFBRUFNUmtVTVJnUVJFSUFDREVaRkRFWUZCQkROaG9CU1JXQkNCSkVGMGsyR2dKSkZTTVNSQ0pUTmhvRFNVNERGWUVnRWtSTWdCQnpjR1Z1WkdsdVoxOWhaR1J5WlhOelpVaE1zVUFCZkRJRElySTRJckkySXJJM0k3STFJckkwZ0FRTGdRRkRza0tBdEFJTElBUUFBUkFJSmdFSmNtVmphWEJwWlc1ME1Sa1VSREVZUVFBT2dBVGdSMUppTmhvQWpnRUFMZ0NBQk14cFRxbzJHZ0NPQVFBU0FJb0NBWXYrUUFBRE1nT0ppLzl5Q0VTSk5ob0JTUldCSUJKRUtFeG5JME1pU1lBQVNUWWFBVWtWSlJKRUYwazJHZ0pKRlNNU1JDSlRURFlhQTBsT0Fra2lXVWxPQXlRTGdRSUlUQlVTUklBUWMzQmxibVJwYm1kZllXUmtjbVZ6YzJWSUlrbExBd3hCQUpCTEExY0NBRXNCSkFza1dFa2lXMGxPQWtVSkpWdEZDVUFBTzdFaUtHVk1SUXRFU3dJakNVc0JEVUVBSHpJRHNpQkxCN0lJU3dteUIwc0JzZ0Fqc2hBaXNnR3pTU01JUlFGQy82NUxCRXNHaVA5RVF2L1pzU0lvWlV4RkNrUkxBaU1KU3dFTlFRQWZNZ095SUVzR3NoRkxCN0lTU3dpeUZFc0JzZ0NCQkxJUUlySUJzMEwvdlVzRVN3YUkvd2xDLzlralE3SkFJcklac2lCSnNnQ0FCTXhwVHFxeUdrc0JzaHFCQnJJUUlySUJzN1E5Rm9BRUZSOThkVXhRc0NORFN3SnlDRVJDL240PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
