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

namespace Arc56.Generated.akita_protocol.akita_sc.MockCompliantProxy_5b454eee
{


    //
    // TEST-ONLY, COMPLIANT twin of `MockPrincipalProxy`: it always hands the spending account back to
    //the calling app in the same call and asserts it did (§3.8 rule 3(b)). `rekeyBack` is ignored.
    //
    public class MockCompliantProxyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockCompliantProxyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Principal : AVMObjectType
            {
                public ulong Wallet { get; set; }

                public Algorand.Address Principal { get; set; }

                public Algorand.Address Origin { get; set; }

                public Algorand.Address Spender { get; set; }

                public Algorand.Address Referrer { get; set; }

                public bool ViaPlugin { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrigin.From(Origin);
                    ret.AddRange(vOrigin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReferrer.From(Referrer);
                    ret.AddRange(vReferrer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vViaPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vViaPlugin.From(ViaPlugin);
                    ret.AddRange(vViaPlugin.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Principal Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Principal();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is ulong vWalletValue) { ret.Wallet = vWalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrincipal = vPrincipal.ToValue();
                    if (valuePrincipal is Algorand.Address vPrincipalValue) { ret.Principal = vPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrigin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrigin = vOrigin.ToValue();
                    if (valueOrigin is Algorand.Address vOriginValue) { ret.Origin = vOriginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReferrer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReferrer = vReferrer.ToValue();
                    if (valueReferrer is Algorand.Address vReferrerValue) { ret.Referrer = vReferrerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vViaPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vViaPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueViaPlugin = vViaPlugin.ToValue();
                    if (valueViaPlugin is bool vViaPluginValue) { ret.ViaPlugin = vViaPluginValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Principal);
                }
                public bool Equals(Principal? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Principal left, Principal right)
                {
                    return EqualityComparer<Principal>.Default.Equals(left, right);
                }
                public static bool operator !=(Principal left, Principal right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        /// <param name="rekeyBack"> </param>
        public async Task<Structs.Principal> Forward(ulong wallet, ulong probe, ulong hint, bool rekeyBack, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 91, 155, 36 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, probeAbi, hintAbi, rekeyBackAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Forward_Transactions(ulong wallet, ulong probe, ulong hint, bool rekeyBack, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 91, 155, 36 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, probeAbi, hintAbi, rekeyBackAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0NvbXBsaWFudFByb3h5IiwiZGVzYyI6IlRFU1QtT05MWSwgQ09NUExJQU5UIHR3aW4gb2YgYE1vY2tQcmluY2lwYWxQcm94eWA6IGl0IGFsd2F5cyBoYW5kcyB0aGUgc3BlbmRpbmcgYWNjb3VudCBiYWNrIHRvXG50aGUgY2FsbGluZyBhcHAgaW4gdGhlIHNhbWUgY2FsbCBhbmQgYXNzZXJ0cyBpdCBkaWQgKMKnMy44IHJ1bGUgMyhiKSkuIGByZWtleUJhY2tgIGlzIGlnbm9yZWQuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlByaW5jaXBhbCI6W3sibmFtZSI6IndhbGxldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcmluY2lwYWwiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im9yaWdpbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3BlbmRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVmZXJyZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InZpYVBsdWdpbiIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImZvcndhcmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGludCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJQcmluY2lwYWwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1Ml0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyUHhoYiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2LDY1LDc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy91dGlscy9wcmluY2lwYWwudHM6OlByaW5jaXBhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2ZUhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTF2WTJ0RGIyMXdiR2xoYm5SUWNtOTRlU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoak1UVmlPV0l5TkNBdkx5QnRaWFJvYjJRZ0ltWnZjbmRoY21Rb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkNrb2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkNraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJadmNuZGhjbVJmY205MWRHVkFNd29nSUNBZ1pYSnlDZ3B0WVdsdVgyWnZjbmRoY21SZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2ZUhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1ptOXlkMkZ5WkNoM1lXeHNaWFE2SUhWcGJuUTJOQ3dnY0hKdlltVTZJRUZ3Y0d4cFkyRjBhVzl1TENCb2FXNTBPaUIxYVc1ME5qUXNJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaWs2SUZCeWFXNWphWEJoYkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQm1iM0ozWVhKa0NncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTk0ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTBOdmJYQnNhV0Z1ZEZCeWIzaDVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIzaDVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazF2WTJ0RGIyMXdiR2xoYm5SUWNtOTRlUzVtYjNKM1lYSmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm05eWQyRnlaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZlSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWm05eWQyRnlaQ2gzWVd4c1pYUTZJSFZwYm5RMk5Dd2djSEp2WW1VNklFRndjR3hwWTJGMGFXOXVMQ0JvYVc1ME9pQjFhVzUwTmpRc0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpazZJRkJ5YVc1amFYQmhiQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRrM0xUVXdNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czTndaVzVrYVc1blFXUmtjbVZ6YzBKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUXNDaUFnSUNBdkx5QWdJRUo1ZEdWektFRmljM1J5WVdOMFFXTmpiM1Z1ZEVkc2IySmhiRk4wWVhSbFMyVjVjMU53Wlc1a2FXNW5RV1JrY21WemN5a0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wT1RrS0lDQWdJQzh2SUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWljM0JsYm1ScGJtZGZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EazNMVFV3TUFvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2ZUhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5TMDBNQW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVnpkV3gwSUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG5CeWIzUnZkSGx3WlM1d2NtOWlaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyaHBiblJkTEFvZ0lDQWdMeThnSUNCeVpXdGxlVlJ2T2lCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZlSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnY21WclpYbFViem9nUjJ4dlltRnNMbU5oYkd4bGNrRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEWVd4c1pYSkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVnJaWGxVYndvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2ZUhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5TMDBNQW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVnpkV3gwSUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG5CeWIzUnZkSGx3WlM1d2NtOWlaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyaHBiblJkTEFvZ0lDQWdMeThnSUNCeVpXdGxlVlJ2T2lCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNeVpEa3dZV0ZoSUM4dklHMWxkR2h2WkNBaWNISnZZbVVvZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UTTNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwUWNtbHVZMmx3WVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2ZUhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJGMWRHaGRJRDBnYjNBdVFXTmpkRkJoY21GdGN5NWhZMk4wUVhWMGFFRmtaSElvYzJWdVpHVnlLUW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUkJkWFJvUVdSa2Nnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjNoNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hoZFhSb0lEMDlQU0JIYkc5aVlXd3VZMkZzYkdWeVFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQW5aWEp5VUhob1lpY3BDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWW01NklHWnZjbmRoY21SZllXWjBaWEpmWVhOelpYSjBRRFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNsQjRhR0lpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VUhob1lnb0tabTl5ZDJGeVpGOWhablJsY2w5aGMzTmxjblJBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2ZUhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1ptOXlkMkZ5WkNoM1lXeHNaWFE2SUhWcGJuUTJOQ3dnY0hKdlltVTZJRUZ3Y0d4cFkyRjBhVzl1TENCb2FXNTBPaUIxYVc1ME5qUXNJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaWs2SUZCeWFXNWphWEJoYkNCN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQ0FFbUFRUVZIM3gxTVJ0QkFCaUFCTUZibXlRMkdnQ09BUUFCQURFWkZERVlFRVJDQUFneEdSUXhHQlFRUXpZYUFVa1ZJaEpFRnpZYUFra1ZJaEpFRnpZYUEwa1ZJaEpFTmhvRUZTTVNSRThDZ0JCemNHVnVaR2x1WjE5aFpHUnlaWE56WlVpeE1nNnlJRW15QUU4Q3NoaUFCRExaQ3FxeUdreXlHb0VHc2hDQkFMSUJzN1ErU1ZjRUFFbE9BazREVndBRUtCSkVGWUdKQVJKRWN3SklNZzRTUUFBUGdBdEZVbEk2WlhKeVVIaG9ZckFBS0V4UXNDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
