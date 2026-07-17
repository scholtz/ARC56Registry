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

namespace Arc56.Generated.algorandfoundation.puya_ts.EchoResource_ed3a0cd3
{


    public class EchoResourceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EchoResourceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EchoResourceByIndexReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static EchoResourceByIndexReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EchoResourceByIndexReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoResourceByIndexReturn);
                }
                public bool Equals(EchoResourceByIndexReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoResourceByIndexReturn left, EchoResourceByIndexReturn right)
                {
                    return EqualityComparer<EchoResourceByIndexReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoResourceByIndexReturn left, EchoResourceByIndexReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        public async Task<Structs.EchoResourceByIndexReturn> EchoResourceByIndex(ulong app, Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 119, 226, 141, 116 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, appRefIndex, accRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoResourceByIndexReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoResourceByIndex_Transactions(ulong app, Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 119, 226, 141, 116 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, appRefIndex, accRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        public async Task<Structs.EchoResourceByIndexReturn> EchoResourceByValue(ulong asset, ulong app, Algorand.Address acc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 55, 2, 118 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, appAbi, accAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoResourceByIndexReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoResourceByValue_Transactions(ulong asset, ulong app, Algorand.Address acc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 55, 2, 118 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, appAbi, accAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNob1Jlc291cmNlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkVjaG9SZXNvdXJjZUJ5SW5kZXhSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImVjaG9SZXNvdXJjZUJ5SW5kZXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYWRkcmVzcykiLCJzdHJ1Y3QiOiJFY2hvUmVzb3VyY2VCeUluZGV4UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob1Jlc291cmNlQnlWYWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiRWNob1Jlc291cmNlQnlJbmRleFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYWNjb3VudCB0byBiZSBwYXNzZWQgYnkgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFjY291bnQgdG8gYmUgcGFzc2VkIGJ5IHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXBwbGljYXRpb24gdG8gYmUgcGFzc2VkIGJ5IGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhcHBsaWNhdGlvbiB0byBiZSBwYXNzZWQgYnkgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTJdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCB0byBiZSBwYXNzZWQgYnkgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFzc2V0IHRvIGJlIHBhc3NlZCBieSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzLDYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3LDEyOCwxMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJqYkdGemN5QkZZMmh2VW1WemIzVnlZMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU9Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE56ZGxNamhrTnpRZ01IZzBaRE0zTURJM05pQXZMeUJ0WlhSb2IyUWdJbVZqYUc5U1pYTnZkWEpqWlVKNVNXNWtaWGdvWVhOelpYUXNZWEJ3YkdsallYUnBiMjRzWVdOamIzVnVkQ2tvZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektTSXNJRzFsZEdodlpDQWlaV05vYjFKbGMyOTFjbU5sUW5sV1lXeDFaU2gxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNcEtIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeWtpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMlZqYUc5U1pYTnZkWEpqWlVKNVNXNWtaWGhmY205MWRHVkFOQ0J0WVdsdVgyVmphRzlTWlhOdmRYSmpaVUo1Vm1Gc2RXVmZjbTkxZEdWQU5Rb2dJQ0FnWlhKeUNncHRZV2x1WDJWamFHOVNaWE52ZFhKalpVSjVWbUZzZFdWZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVnpiM1Z5WTJWRmJtTnZaR2x1WnpvZ0ozWmhiSFZsSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzSmxjMjkxY21ObExXVnVZMjlrYVc1bkxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBTV1FnUFNCdmNDNWlkRzlwS0ZSNGJpNWhjSEJzYVdOaGRHbHZia0Z5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNtVnpiM1Z5WTJVdFpXNWpiMlJwYm1jdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1lYTnpaWEowS0dGemMyVjBJRDA5UFNCQmMzTmxkQ2hoYzNObGRFbGtLU3dnSjJWNGNHVmpkR1ZrSUdGemMyVjBJSFJ2SUdKbElIQmhjM05sWkNCaWVTQjJZV3gxWlNjcENpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoYzNObGRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkpaQ0E5SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVRWEpuY3lneUtTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCaGMzTmxjblFvWVhCd0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloaGNIQkpaQ2tzSUNkbGVIQmxZM1JsWkNCaGNIQnNhV05oZEdsdmJpQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VuS1FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZWEJ3YkdsallYUnBiMjRnZEc4Z1ltVWdjR0Z6YzJWa0lHSjVJSFpoYkhWbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnWVhOelpYSjBLR0ZqWXlBOVBUMGdRV05qYjNWdWRDaGhaR1J5WlhOektTd2dKMlY0Y0dWamRHVmtJR0ZqWTI5MWJuUWdkRzhnWW1VZ2NHRnpjMlZrSUdKNUlIWmhiSFZsSnlrS0lDQWdJR1IxY0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR052Ym5OMElHRmtaSEpsYzNNZ1BTQlVlRzR1WVhCd2JHbGpZWFJwYjI1QmNtZHpLRE1wQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjbVZ6YjNWeVkyVXRaVzVqYjJScGJtY3VZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdZWE56WlhKMEtHRmpZeUE5UFQwZ1FXTmpiM1Z1ZENoaFpHUnlaWE56S1N3Z0oyVjRjR1ZqZEdWa0lHRmpZMjkxYm5RZ2RHOGdZbVVnY0dGemMyVmtJR0o1SUhaaGJIVmxKeWtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1lXTmpiM1Z1ZENCMGJ5QmlaU0J3WVhOelpXUWdZbmtnZG1Gc2RXVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCeVpYUjFjbTRnVzJGemMyVjBMQ0JoY0hBc0lHRmpZMTBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaWE52ZFhKalpVVnVZMjlrYVc1bk9pQW5kbUZzZFdVbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVmphRzlTWlhOdmRYSmpaVUo1U1c1a1pYaGZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZ6YjNWeVkyVkZibU52WkdsdVp6b2dKMmx1WkdWNEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblE0Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmMzTmxkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYQndiR2xqWVhScGIyNXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjbVZ6YjNWeVkyVXRaVzVqYjJScGJtY3VZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdZMjl1YzNRZ1lYTnpaWFJKWkhnZ1BTQnZjQzVpZEc5cEtGUjRiaTVoY0hCc2FXTmhkR2x2YmtGeVozTW9NU2twQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjbVZ6YjNWeVkyVXRaVzVqYjJScGJtY3VZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdZWE56WlhKMEtHRnpjMlYwSUQwOVBTQlVlRzR1WVhOelpYUnpLR0Z6YzJWMFNXUjRLU3dnSjJWNGNHVmpkR1ZrSUdGemMyVjBJSFJ2SUdKbElIQmhjM05sWkNCaWVTQnBibVJsZUNjcENpQWdJQ0IwZUc1aGN5QkJjM05sZEhNS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z6YzJWMElIUnZJR0psSUhCaGMzTmxaQ0JpZVNCcGJtUmxlQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzSmxjMjkxY21ObExXVnVZMjlrYVc1bkxtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklHTnZibk4wSUdGd2NFbGtlQ0E5SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVRWEpuY3lneUtTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCaGMzTmxjblFvWVhCd0lEMDlQU0JVZUc0dVlYQndiR2xqWVhScGIyNXpLR0Z3Y0Vsa2VDa3NJQ2RsZUhCbFkzUmxaQ0JoY0hCc2FXTmhkR2x2YmlCMGJ5QmlaU0J3WVhOelpXUWdZbmtnYVc1a1pYZ25LUW9nSUNBZ2RIaHVZWE1nUVhCd2JHbGpZWFJwYjI1ekNpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoY0hCc2FXTmhkR2x2YmlCMGJ5QmlaU0J3WVhOelpXUWdZbmtnYVc1a1pYZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCamIyNXpkQ0JoWTJOSlpIZ2dQU0J2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJrRnlaM01vTXlrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWVhOelpYSjBLR0ZqWXlBOVBUMGdWSGh1TG1GalkyOTFiblJ6S0dGalkwbGtlQ2tzSUNkbGVIQmxZM1JsWkNCaFkyTnZkVzUwSUhSdklHSmxJSEJoYzNObFpDQmllU0JwYm1SbGVDY3BDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1lXTmpiM1Z1ZENCMGJ5QmlaU0J3WVhOelpXUWdZbmtnYVc1a1pYZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCeVpYUjFjbTRnVzJGemMyVjBMQ0JoY0hBc0lHRmpZMTBnWVhNZ1kyOXVjM1FLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaWE52ZFhKalpVVnVZMjlrYVc1bk9pQW5hVzVrWlhnbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdOc1lYTnpJRVZqYUc5U1pYTnZkWEpqWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQVFnbUFRUVZIM3gxTVJ0QkFLc3hHUlJFTVJoRWdnSUVkK0tOZEFSTk53SjJOaG9BamdJQVFRQUJBRFlhQVVrVkl4SkVGellhQWtrVkl4SkVGellhQTBrVmdTQVNSRFlhQVJkTEF4SkVOaG9DRjBzQ0VrUkpOaG9ERWtSUEFoWlBBaFpRVEZBb1RGQ3dJa00yR2dGSkZTSVNSQmZBTURZYUFra1ZJaEpFRjhBeU5ob0RTUlVpRWtRWHdCdzJHZ0VYd0RCTEF4SkVOaG9DRjhBeVN3SVNSRFlhQXhmQUhFc0JFa1JQQWhaUEFoWlFURkFvVEZDd0lrTXhHUlF4R0JRUVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
