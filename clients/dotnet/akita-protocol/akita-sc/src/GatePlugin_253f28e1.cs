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

namespace Arc56.Generated.akita_protocol.akita_sc.GatePlugin_253f28e1
{


    public class GatePluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GatePluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RegisterArgFilters : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RegisterArgFilters Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RegisterArgFilters();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RegisterArgFilters);
                }
                public bool Equals(RegisterArgFilters? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RegisterArgFilters left, RegisterArgFilters right)
                {
                    return EqualityComparer<RegisterArgFilters>.Default.Equals(left, right);
                }
                public static bool operator !=(RegisterArgFilters left, RegisterArgFilters right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="gateAppID"> </param>
        public async Task Create(ulong gateAppID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var gateAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateAppIDAbi.From(gateAppID);

            var result = await base.CallApp(new List<object> { abiHandle, gateAppIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong gateAppID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var gateAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateAppIDAbi.From(gateAppID);

            return await base.MakeTransactionList(new List<object> { abiHandle, gateAppIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="filters"> RegisterArgFilters</param>
        /// <param name="args"> </param>
        public async Task Register(ulong wallet, bool rekeyBack, Structs.RegisterArgFilters[] filters, byte[][] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 163, 18, 54 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var filtersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.RegisterArgFilters>(x => Structs.RegisterArgFilters.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; filtersAbi.From(filters);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, filtersAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(ulong wallet, bool rekeyBack, Structs.RegisterArgFilters[] filters, byte[][] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 163, 18, 54 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var filtersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.RegisterArgFilters>(x => Structs.RegisterArgFilters.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; filtersAbi.From(filters);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, filtersAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2F0ZVBsdWdpbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZWdpc3RlckFyZ0ZpbHRlcnMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50OCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZUFwcElEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDgpW10iLCJzdHJ1Y3QiOiJSZWdpc3RlckFyZ0ZpbHRlcnMiLCJuYW1lIjoiZmlsdGVycyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjYxLDMzOV0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsMzUwXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNSwxMjEsMTY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxieXRlcz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy9nYXRlcy90eXBlcy50czo6R2F0ZUZpbHRlcj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MCw4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NiwzNDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlaMkYwWlY5aGNIQmZhV1FpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyZGhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFZGhkR1ZRYkhWbmFXNGdaWGgwWlc1a2N5QkNZWE5sUjJGMFpTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURKbVlUTXhNak0ySUM4dklHMWxkR2h2WkNBaWNtVm5hWE4wWlhJb2RXbHVkRFkwTEdKdmIyd3NLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRGdwVzEwc1lubDBaVnRkVzEwcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhKbFoybHpkR1Z5Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyZGhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFZGhkR1ZRYkhWbmFXNGdaWGgwWlc1a2N5QkNZWE5sUjJGMFpTQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lOREJrTW1ZMk55QXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZaMkYwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwSFlYUmxVR3gxWjJsdUxtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyZGhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyZGhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWjJGMFpVRndjRWxFSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIWVhSbFVHeDFaMmx1UjJ4dlltRnNVM1JoZEdWTFpYbEhZWFJsUVhCd1NVUWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWRoZEdWZllYQndYMmxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdloyRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUIwYUdsekxtZGhkR1ZCY0hCSlJDNTJZV3gxWlNBOUlFRndjR3hwWTJGMGFXOXVLR2RoZEdWQmNIQkpSQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5bllYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZaMkYwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwSFlYUmxVR3gxWjJsdUxuSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OW5ZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpndE16TUtJQ0FnSUM4dklISmxaMmx6ZEdWeUtBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUdacGJIUmxjbk02SUVkaGRHVkdhV3gwWlhKYlhTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1IyRjBaVUZ5WjNNS0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVGNLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeHpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12ZEhsd1pYTXVkSE02T2tkaGRHVkdhV3gwWlhJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dweVpXZHBjM1JsY2w5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTluWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ3RNek1LSUNBZ0lDOHZJSEpsWjJsemRHVnlLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lHWnBiSFJsY25NNklFZGhkR1ZHYVd4MFpYSmJYU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dSMkYwWlVGeVozTUtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdZbm9nY21WbmFYTjBaWEpmWVdaMFpYSmZabTl5UURRS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2daVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0d4bGJpc29iR1Z1SzNWcGJuUTRXMTBwVzEwcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCeVpXZHBjM1JsY2w5bWIzSmZhR1ZoWkdWeVFERUtDbkpsWjJsemRHVnlYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdloyRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0TFRNekNpQWdJQ0F2THlCeVpXZHBjM1JsY2lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdjbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0JtYVd4MFpYSnpPaUJIWVhSbFJtbHNkR1Z5VzEwc0NpQWdJQ0F2THlBZ0lHRnlaM002SUVkaGRHVkJjbWR6Q2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aWVYUmxjejRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNamN3TFRJM013b2dJQ0FnTHk4Z1kyOXVjM1FnVzNOd1pXNWthVzVuUVdSa2NtVnpjMEo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lFSjVkR1Z6S0VGaWMzUnlZV04wUVdOamIzVnVkRWRzYjJKaGJGTjBZWFJsUzJWNWMxTndaVzVrYVc1blFXUmtjbVZ6Y3lrS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJM01nb2dJQ0FnTHk4Z1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p6Y0dWdVpHbHVaMTloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lOekF0TWpjekNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTluWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VXRNemdLSUNBZ0lDOHZJR052Ym5OMElHRnRiM1Z1ZENBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUVkaGRHVXVjSEp2ZEc5MGVYQmxMbU52YzNRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11WjJGMFpVRndjRWxFTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJabWxzZEdWeWN5d2dZWEpuYzEwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZaMkYwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCaGNIQkpaRG9nZEdocGN5NW5ZWFJsUVhCd1NVUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdloyRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJuWVhSbFFYQndTVVFnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRoZEdWUWJIVm5hVzVIYkc5aVlXeFRkR0YwWlV0bGVVZGhkR1ZCY0hCSlJDQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaMkYwWlY5aGNIQmZhV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5bllYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR0Z3Y0Vsa09pQjBhR2x6TG1kaGRHVkJjSEJKUkM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OW5ZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVdE16Z0tJQ0FnSUM4dklHTnZibk4wSUdGdGIzVnVkQ0E5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRWRoZEdVdWNISnZkRzkwZVhCbExtTnZjM1ErS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhSb2FYTXVaMkYwWlVGd2NFbEVMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlptbHNkR1Z5Y3l3Z1lYSm5jMTBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6VmpPVEZtT0dZZ0x5OGdiV1YwYUc5a0lDSmpiM04wS0NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNEtWdGRMR0o1ZEdWYlhWdGRLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QTNDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhWcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WjJGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdMVFV6Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkhZWFJsTG5CeWIzUnZkSGx3WlM1eVpXZHBjM1JsY2o0b2V3b2dJQ0FnTHk4Z0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbWRoZEdWQmNIQkpSQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJR2wwZUc0dWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdJQ0J6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTVuWVhSbFFYQndTVVF1ZG1Gc2RXVXVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0FnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCOUtTd0tJQ0FnSUM4dklDQWdJQ0JtYVd4MFpYSnpMQW9nSUNBZ0x5OGdJQ0FnSUdGeVozTXNDaUFnSUNBdkx5QWdJRjBzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVWRzg2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa0tJQ0FnSUM4dklIMHBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OW5ZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUhKbFkyVnBkbVZ5T2lCMGFHbHpMbWRoZEdWQmNIQkpSQzUyWVd4MVpTNWhaR1J5WlhOekxBb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5bllYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFF0TkRnS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJSFJvYVhNdVoyRjBaVUZ3Y0VsRUxuWmhiSFZsTG1Ga1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJSDBwTEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZaMkYwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd0xUVXpDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCSFlYUmxMbkJ5YjNSdmRIbHdaUzV5WldkcGMzUmxjajRvZXdvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIwYUdsekxtZGhkR1ZCY0hCSlJDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdJQ0J5WldObGFYWmxjam9nZEdocGN5NW5ZWFJsUVhCd1NVUXVkbUZzZFdVdVlXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0I5S1N3S0lDQWdJQzh2SUNBZ0lDQm1hV3gwWlhKekxBb2dJQ0FnTHk4Z0lDQWdJR0Z5WjNNc0NpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNekkyQ2lBZ0lDQXZMeUJwWmlBb0lYSmxhMlY1UW1GamF5a2dld29nSUNBZ1pHbG5JRGNLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk16STNDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LQ25KbFoybHpkR1Z5WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbVZyWlhsQlpHUnlaWE56UURFd09nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXdGxlVlJ2Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5bllYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREF0TlRNS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRWRoZEdVdWNISnZkRzkwZVhCbExuSmxaMmx6ZEdWeVBpaDdDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11WjJGMFpVRndjRWxFTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0FnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNBZ0lISmxZMlZwZG1WeU9pQjBhR2x6TG1kaGRHVkJjSEJKUkM1MllXeDFaUzVoWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lIMHBMQW9nSUNBZ0x5OGdJQ0FnSUdacGJIUmxjbk1zQ2lBZ0lDQXZMeUFnSUNBZ1lYSm5jeXdLSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ0x5OGdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR015TVdNM1ltRXdJQzh2SUcxbGRHaHZaQ0FpY21WbmFYTjBaWElvY0dGNUxDaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTRLVnRkTEdKNWRHVmJYVnRkS1hWcGJuUTJOQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyZGhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0Mwek13b2dJQ0FnTHk4Z2NtVm5hWE4wWlhJb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWm1sc2RHVnljem9nUjJGMFpVWnBiSFJsY2x0ZExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCSFlYUmxRWEpuY3dvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXZHBjM1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPak16TUFvZ0lDQWdMeThnY21WMGRYSnVJSGRoYkd4bGRDNWhaR1J5WlhOekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZaMkYwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNCaUlISmxaMmx6ZEdWeVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem82Y21WclpYbEJaR1J5WlhOelFERXdDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lDQzJkaGRHVmZZWEJ3WDJsa0JCVWZmSFV4R1JSRU1SaEJBQTZBQkMrakVqWTJHZ0NPQVFBZEFJQUVKQTB2WnpZYUFJNEJBQUVBTmhvQlNSVWxFa1FYS0V4bkkwTWlnQUEyR2dGSkZTVVNSQmMyR2dKSkZTTVNSQ0pUTmhvRFJ3SWlXWUVSQ3lRSVRCVVNSRFlhQkVjQ0lsbEpUZ0lrQzB4SkZVeFhBZ0FpU1VzRkRFRUFKRWNDSkF0TEEwbFBBbGxKU3dkSlRnUVNSRXNCRlZJaVdTUUlDRVVGSXdoRkFVTC8xVXNESkFoTEF4SkVTd2lBRUhOd1pXNWthVzVuWDJGa1pISmxjM05sU0VsRkRMRWlLR1ZNU1U0Q1JRMUVTYklZZ0FURnlSK1BzaHBMQ0xJYVN3ZXlHb0VHc2hBaXNnR3p0RDVKVndRQVRGY0FCQ2tTUkVrVkpSSkVGN0ZNY2doRXNnZXlDTElBSTdJUUlySUJ0a3NIUUFBM01nT3lJRXNKc2hoTENySUFnQVRDSEh1Z3NocExCcklhU3dXeUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDa1NSQlVsRWtRalEwc0ljZ2hFUXYvRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
