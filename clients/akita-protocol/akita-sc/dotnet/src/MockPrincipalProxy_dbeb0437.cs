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

namespace Arc56.Generated.akita_protocol.akita_sc.MockPrincipalProxy_dbeb0437
{


    //
    // TEST-ONLY, NON-COMPLIANT proxy B (E9/E25, T14/T41). Sends `probe.probe(hint)` as
    //`getSpendingAccount(wallet)` and hands that account to its caller only when `rekeyBack`.
    //With `rekeyBack = false` it KEEPS the account, which violates the custody rule
    //(docs/principal-resolution/STANDARD.md, §3.8 rule 3(b)): afterwards any app can call `forward`
    //with a forged wallet whose `spending_address` is that account. Never deploy outside tests.
    //
    public class MockPrincipalProxyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockPrincipalProxyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1ByaW5jaXBhbFByb3h5IiwiZGVzYyI6IlRFU1QtT05MWSwgTk9OLUNPTVBMSUFOVCBwcm94eSBCIChFOS9FMjUsIFQxNC9UNDEpLiBTZW5kcyBgcHJvYmUucHJvYmUoaGludClgIGFzXG5gZ2V0U3BlbmRpbmdBY2NvdW50KHdhbGxldClgIGFuZCBoYW5kcyB0aGF0IGFjY291bnQgdG8gaXRzIGNhbGxlciBvbmx5IHdoZW4gYHJla2V5QmFja2AuXG5XaXRoIGByZWtleUJhY2sgPSBmYWxzZWAgaXQgS0VFUFMgdGhlIGFjY291bnQsIHdoaWNoIHZpb2xhdGVzIHRoZSBjdXN0b2R5IHJ1bGVcbihkb2NzL3ByaW5jaXBhbC1yZXNvbHV0aW9uL1NUQU5EQVJELm1kLCDCpzMuOCBydWxlIDMoYikpOiBhZnRlcndhcmRzIGFueSBhcHAgY2FuIGNhbGwgYGZvcndhcmRgXG53aXRoIGEgZm9yZ2VkIHdhbGxldCB3aG9zZSBgc3BlbmRpbmdfYWRkcmVzc2AgaXMgdGhhdCBhY2NvdW50LiBOZXZlciBkZXBsb3kgb3V0c2lkZSB0ZXN0cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJpbmNpcGFsIjpbeyJuYW1lIjoid2FsbGV0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaW5jaXBhbCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3JpZ2luIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzcGVuZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZWZlcnJlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidmlhUGx1Z2luIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZm9yd2FyZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTU0XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3LDY2LDc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy91dGlscy9wcmluY2lwYWwudHM6OlByaW5jaXBhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBeElEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205NGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVFc5amExQnlhVzVqYVhCaGJGQnliM2g1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTXhOV0k1WWpJMElDOHZJRzFsZEdodlpDQWlabTl5ZDJGeVpDaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0tTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0tTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlptOXlkMkZ5WkY5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZabTl5ZDJGeVpGOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205NGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5Qm1iM0ozWVhKa0tIZGhiR3hsZERvZ2RXbHVkRFkwTENCd2NtOWlaVG9nUVhCd2JHbGpZWFJwYjI0c0lHaHBiblE2SUhWcGJuUTJOQ3dnY21WclpYbENZV05yT2lCaWIyOXNaV0Z1S1RvZ1VISnBibU5wY0dGc0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJR1p2Y25kaGNtUUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjNoNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOYjJOclVISnBibU5wY0dGc1VISnZlSGtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZlSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amExQnlhVzVqYVhCaGJGQnliM2g1TG1admNuZGhjbVJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWIzSjNZWEprT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTk0ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCbWIzSjNZWEprS0hkaGJHeGxkRG9nZFdsdWREWTBMQ0J3Y205aVpUb2dRWEJ3YkdsallYUnBiMjRzSUdocGJuUTZJSFZwYm5RMk5Dd2djbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVLVG9nVUhKcGJtTnBjR0ZzSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qUTVOeTAxTURBS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalE1T1FvZ0lDQWdMeThnUW5sMFpYTW9RV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VTNCbGJtUnBibWRCWkdSeVpYTnpLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpjR1Z1WkdsdVoxOWhaR1J5WlhOeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME9UY3ROVEF3Q2lBZ0lDQXZMeUJqYjI1emRDQmJjM0JsYm1ScGJtZEJaR1J5WlhOelFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkQ3dLSUNBZ0lDOHZJQ0FnUW5sMFpYTW9RV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VTNCbGJtUnBibWRCWkdSeVpYTnpLUW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTk0ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUxUSTBDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG5CeWIzUnZkSGx3WlM1d2NtOWlaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyaHBiblJkTEFvZ0lDQWdMeThnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUpoWTJzZ1B5QkhiRzlpWVd3dVkyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56SURvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdmVIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdjbVZyWlhsVWJ6b2djbVZyWlhsQ1lXTnJJRDhnUjJ4dlltRnNMbU5oYkd4bGNrRndjR3hwWTJGMGFXOXVRV1JrY21WemN5QTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lHSjZJR1p2Y25kaGNtUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0JuYkc5aVlXd2dRMkZzYkdWeVFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNncG1iM0ozWVhKa1gzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205NGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVMVEkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXOWphMUJ5YVc1amFYQmhiRkJ5YjJKbExuQnliM1J2ZEhsd1pTNXdjbTlpWlQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2NISnZZbVVzQ2lBZ0lDQXZMeUFnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMmhwYm5SZExBb2dJQ0FnTHk4Z0lDQnlaV3RsZVZSdk9pQnlaV3RsZVVKaFkyc2dQeUJIYkc5aVlXd3VZMkZzYkdWeVFYQndiR2xqWVhScGIyNUJaR1J5WlhOeklEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNeVpEa3dZV0ZoSUM4dklHMWxkR2h2WkNBaWNISnZZbVVvZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TXpjS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbEJ5YVc1amFYQmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOTRlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJtYjNKM1lYSmtLSGRoYkd4bGREb2dkV2x1ZERZMExDQndjbTlpWlRvZ1FYQndiR2xqWVhScGIyNHNJR2hwYm5RNklIVnBiblEyTkN3Z2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21admNuZGhjbVJmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOTRlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJ5Wld0bGVWUnZPaUJ5Wld0bGVVSmhZMnNnUHlCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpJRG9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaUlHWnZjbmRoY21SZmRHVnlibUZ5ZVY5dFpYSm5aVUEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURDQUVBSmdFRUZSOThkVEViUVFBWWdBVEJXNXNrTmhvQWpnRUFBUUF4R1JReEdCQkVRZ0FJTVJrVU1SZ1VFRU0yR2dGSkZTSVNSQmMyR2dKSkZTSVNSQmRNTmhvRFNVNENGU0lTUkRZYUJFa1ZJeEpFSkZOTWdCQnpjR1Z1WkdsdVoxOWhaR1J5WlhOelpVaE1zVUVBTlRJT3NpQ3lBRXl5R0lBRU10a0txcklhc2hxQkJySVFKTElCczdRK1NWY0VBRXhYQUFRb0VrUkpGWUdKQVJKRUtFeFFzQ05ETWdOQy84Zz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
