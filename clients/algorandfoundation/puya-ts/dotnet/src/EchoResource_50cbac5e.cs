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

namespace Arc56.Generated.algorandfoundation.puya_ts.EchoResource_50cbac5e
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNob1Jlc291cmNlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkVjaG9SZXNvdXJjZUJ5SW5kZXhSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImVjaG9SZXNvdXJjZUJ5SW5kZXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYWRkcmVzcykiLCJzdHJ1Y3QiOiJFY2hvUmVzb3VyY2VCeUluZGV4UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob1Jlc291cmNlQnlWYWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiRWNob1Jlc291cmNlQnlJbmRleFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjQzXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYWNjb3VudCB0byBiZSBwYXNzZWQgYnkgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhY2NvdW50IHRvIGJlIHBhc3NlZCBieSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMl0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFwcGxpY2F0aW9uIHRvIGJlIHBhc3NlZCBieSBpbmRleCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFwcGxpY2F0aW9uIHRvIGJlIHBhc3NlZCBieSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMl0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFzc2V0IHRvIGJlIHBhc3NlZCBieSBpbmRleCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Ml0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFzc2V0IHRvIGJlIHBhc3NlZCBieSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzEsMTgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5LDEzMCwxNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJREI0Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREVLQ20xaGFXNWZZbXh2WTJ0QU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCamJHRnpjeUJGWTJodlVtVnpiM1Z5WTJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBNUNpQWdJQ0JpSUcxaGFXNWZZV0pwWDNKdmRYUnBibWRBTWdvS2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdOc1lYTnpJRVZqYUc5U1pYTnZkWEpqWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEY0tJQ0FnSUdJZ2JXRnBibDlqWVd4c1gwNXZUM0JBTXdvS2JXRnBibDlqWVd4c1gwNXZUM0JBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJqYkdGemN5QkZZMmh2VW1WemIzVnlZMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczTjJVeU9HUTNOQ0F2THlCdFpYUm9iMlFnSW1WamFHOVNaWE52ZFhKalpVSjVTVzVrWlhnb1lYTnpaWFFzWVhCd2JHbGpZWFJwYjI0c1lXTmpiM1Z1ZENrb2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJrTXpjd01qYzJJQzh2SUcxbGRHaHZaQ0FpWldOb2IxSmxjMjkxY21ObFFubFdZV3gxWlNoMWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXBLSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3lraUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHMWhkR05vSUcxaGFXNWZaV05vYjFKbGMyOTFjbU5sUW5sSmJtUmxlRjl5YjNWMFpVQTBJRzFoYVc1ZlpXTm9iMUpsYzI5MWNtTmxRbmxXWVd4MVpWOXliM1YwWlVBMUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5qb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmpiR0Z6Y3lCRlkyaHZVbVZ6YjNWeVkyVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZlpXTm9iMUpsYzI5MWNtTmxRbmxXWVd4MVpWOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaWE52ZFhKalpVVnVZMjlrYVc1bk9pQW5kbUZzZFdVbklIMHBDaUFnSUNCallXeHNjM1ZpSUdWamFHOVNaWE52ZFhKalpVSjVWbUZzZFdVS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEWUtDbTFoYVc1ZlpXTm9iMUpsYzI5MWNtTmxRbmxKYm1SbGVGOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaWE52ZFhKalpVVnVZMjlrYVc1bk9pQW5hVzVrWlhnbklIMHBDaUFnSUNCallXeHNjM1ZpSUdWamFHOVNaWE52ZFhKalpVSjVTVzVrWlhnS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEWUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFOem9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGdLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNtVnpiM1Z5WTJVdFpXNWpiMlJwYm1jdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1kyeGhjM01nUldOb2IxSmxjMjkxY21ObElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pwRlkyaHZVbVZ6YjNWeVkyVXVaV05vYjFKbGMyOTFjbU5sUW5sSmJtUmxlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WamFHOVNaWE52ZFhKalpVSjVTVzVrWlhnNkNpQWdJQ0JpSUdWamFHOVNaWE52ZFhKalpVSjVTVzVrWlhoZllteHZZMnRBTUFvS1pXTm9iMUpsYzI5MWNtTmxRbmxKYm1SbGVGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaWE52ZFhKalpVVnVZMjlrYVc1bk9pQW5hVzVrWlhnbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblE0Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmNIQnNhV05oZEdsdmJuTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZPa1ZqYUc5U1pYTnZkWEpqWlM1bFkyaHZVbVZ6YjNWeVkyVkNlVWx1WkdWNENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNtVnpiM1Z5WTJVdFpXNWpiMlJwYm1jdVlXeG5ieTUwY3pvNlJXTm9iMUpsYzI5MWNtTmxMbVZqYUc5U1pYTnZkWEpqWlVKNVZtRnNkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbFkyaHZVbVZ6YjNWeVkyVkNlVlpoYkhWbE9nb2dJQ0FnWWlCbFkyaHZVbVZ6YjNWeVkyVkNlVlpoYkhWbFgySnNiMk5yUURBS0NtVmphRzlTWlhOdmRYSmpaVUo1Vm1Gc2RXVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZ6YjNWeVkyVkZibU52WkdsdVp6b2dKM1poYkhWbEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem82UldOb2IxSmxjMjkxY21ObExtVmphRzlTWlhOdmRYSmpaVUo1Vm1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qcEZZMmh2VW1WemIzVnlZMlV1WldOb2IxSmxjMjkxY21ObFFubEpibVJsZUNoaGMzTmxkRG9nZFdsdWREWTBMQ0JoY0hBNklIVnBiblEyTkN3Z1lXTmpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qcEZZMmh2VW1WemIzVnlZMlV1WldOb2IxSmxjMjkxY21ObFFubEpibVJsZURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPak01TFRRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZ6YjNWeVkyVkZibU52WkdsdVp6b2dKMmx1WkdWNEp5QjlLUW9nSUNBZ0x5OGdaV05vYjFKbGMyOTFjbU5sUW5sSmJtUmxlQ2hoYzNObGREb2dRWE56WlhRc0lHRndjRG9nUVhCd2JHbGpZWFJwYjI0c0lHRmpZem9nUVdOamIzVnVkQ2s2SUZ0QmMzTmxkQ3dnUVhCd2JHbGpZWFJwYjI0c0lFRmpZMjkxYm5SZElIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjbVZ6YjNWeVkyVXRaVzVqYjJScGJtY3VZV3huYnk1MGN6bzZSV05vYjFKbGMyOTFjbU5sTG1WamFHOVNaWE52ZFhKalpVSjVTVzVrWlhoZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02T2tWamFHOVNaWE52ZFhKalpTNWxZMmh2VW1WemIzVnlZMlZDZVVsdVpHVjRYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNtVnpiM1Z5WTJVdFpXNWpiMlJwYm1jdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1kyOXVjM1FnWVhOelpYUkpaSGdnUFNCdmNDNWlkRzlwS0ZSNGJpNWhjSEJzYVdOaGRHbHZia0Z5WjNNb01Ta3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnZEhodVlYTWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWVhOelpYSjBLR0Z6YzJWMElEMDlQU0JVZUc0dVlYTnpaWFJ6S0dGemMyVjBTV1I0S1N3Z0oyVjRjR1ZqZEdWa0lHRnpjMlYwSUhSdklHSmxJSEJoYzNObFpDQmllU0JwYm1SbGVDY3BDaUFnSUNCMGVHNWhjeUJCYzNObGRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoYzNObGRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2FXNWtaWGdLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkpaSGdnUFNCdmNDNWlkRzlwS0ZSNGJpNWhjSEJzYVdOaGRHbHZia0Z5WjNNb01pa3BDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnZEhodVlYTWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnWVhOelpYSjBLR0Z3Y0NBOVBUMGdWSGh1TG1Gd2NHeHBZMkYwYVc5dWN5aGhjSEJKWkhncExDQW5aWGh3WldOMFpXUWdZWEJ3YkdsallYUnBiMjRnZEc4Z1ltVWdjR0Z6YzJWa0lHSjVJR2x1WkdWNEp5a0tJQ0FnSUhSNGJtRnpJRUZ3Y0d4cFkyRjBhVzl1Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHRndjR3hwWTJGMGFXOXVJSFJ2SUdKbElIQmhjM05sWkNCaWVTQnBibVJsZUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR052Ym5OMElHRmpZMGxrZUNBOUlHOXdMbUowYjJrb1ZIaHVMbUZ3Y0d4cFkyRjBhVzl1UVhKbmN5Z3pLU2tLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnZEhodVlYTWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWVhOelpYSjBLR0ZqWXlBOVBUMGdWSGh1TG1GalkyOTFiblJ6S0dGalkwbGtlQ2tzSUNkbGVIQmxZM1JsWkNCaFkyTnZkVzUwSUhSdklHSmxJSEJoYzNObFpDQmllU0JwYm1SbGVDY3BDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGalkyOTFiblFnZEc4Z1ltVWdjR0Z6YzJWa0lHSjVJR2x1WkdWNENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnY21WMGRYSnVJRnRoYzNObGRDd2dZWEJ3TENCaFkyTmRJR0Z6SUdOdmJuTjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pwRlkyaHZVbVZ6YjNWeVkyVXVaV05vYjFKbGMyOTFjbU5sUW5sV1lXeDFaU2hoYzNObGREb2dkV2x1ZERZMExDQmhjSEE2SUhWcGJuUTJOQ3dnWVdOak9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pwRlkyaHZVbVZ6YjNWeVkyVXVaV05vYjFKbGMyOTFjbU5sUW5sV1lXeDFaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qVXdMVFV4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVnpiM1Z5WTJWRmJtTnZaR2x1WnpvZ0ozWmhiSFZsSnlCOUtRb2dJQ0FnTHk4Z1pXTm9iMUpsYzI5MWNtTmxRbmxXWVd4MVpTaGhjM05sZERvZ1FYTnpaWFFzSUdGd2NEb2dRWEJ3YkdsallYUnBiMjRzSUdGall6b2dRV05qYjNWdWRDazZJRnRCYzNObGRDd2dRWEJ3YkdsallYUnBiMjRzSUVGalkyOTFiblJkSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmNtVnpiM1Z5WTJVdFpXNWpiMlJwYm1jdVlXeG5ieTUwY3pvNlJXTm9iMUpsYzI5MWNtTmxMbVZqYUc5U1pYTnZkWEpqWlVKNVZtRnNkV1ZmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZPa1ZqYUc5U1pYTnZkWEpqWlM1bFkyaHZVbVZ6YjNWeVkyVkNlVlpoYkhWbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWTI5dWMzUWdZWE56WlhSSlpDQTlJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVFYSm5jeWd4S1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQjBlRzVoY3lCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QmhjM05sY25Rb1lYTnpaWFFnUFQwOUlFRnpjMlYwS0dGemMyVjBTV1FwTENBblpYaHdaV04wWldRZ1lYTnpaWFFnZEc4Z1ltVWdjR0Z6YzJWa0lHSjVJSFpoYkhWbEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoYzNObGRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkpaQ0E5SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVRWEpuY3lneUtTa0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0IwZUc1aGN5QkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZWEJ3SUQwOVBTQkJjSEJzYVdOaGRHbHZiaWhoY0hCSlpDa3NJQ2RsZUhCbFkzUmxaQ0JoY0hCc2FXTmhkR2x2YmlCMGJ5QmlaU0J3WVhOelpXUWdZbmtnZG1Gc2RXVW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGd2NHeHBZMkYwYVc5dUlIUnZJR0psSUhCaGMzTmxaQ0JpZVNCMllXeDFaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzSmxjMjkxY21ObExXVnVZMjlrYVc1bkxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHTnZibk4wSUdGa1pISmxjM01nUFNCVWVHNHVZWEJ3YkdsallYUnBiMjVCY21kektETXBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSFI0Ym1GeklFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhZMk1nUFQwOUlFRmpZMjkxYm5Rb1lXUmtjbVZ6Y3lrc0lDZGxlSEJsWTNSbFpDQmhZMk52ZFc1MElIUnZJR0psSUhCaGMzTmxaQ0JpZVNCMllXeDFaU2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1lXTmpiM1Z1ZENCMGJ5QmlaU0J3WVhOelpXUWdZbmtnZG1Gc2RXVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCeVpYUjFjbTRnVzJGemMyVjBMQ0JoY0hBc0lHRmpZMTBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzSmxjMjkxY21ObExXVnVZMjlrYVc1bkxtRnNaMjh1ZEhNNk9rVmphRzlTWlhOdmRYSmpaUzVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUlBaVlDQkJVZmZIVUFRZ0FBUWdBQU1Sc2pFMEVBUWtJQUFERVpJeEpFTVJnakUwRUFNRUlBQURZYUFJQUVkK0tOZElBRVRUY0NkazhDamdJQUVBQUtRZ0FBUWdBQVFnQUFBSWdBVDBMLzg0Z0FGVUwvN1VMLzdURVpJeEl4R0NNU0VFU0lBTVVpUTBJQUFEWWFBVWtWSWhKRUY4QXdOaG9DU1JVaUVrUVh3REkyR2dOSkZTSVNSQmZBSEU4Q1R3SlBBb2dBTlNoUEFWQ3dJa05DQUFBMkdnRkpGU1FTUkJjMkdnSkpGU1FTUkJjMkdnTkpGWUVnRWtSUEFrOENUd0tJQURzb1R3RlFzQ0pEaWdNQlFnQUFJc0FhRjhBd2kvMFNSQ1hBR2hmQU1vditFa1NCQThBYUY4QWNpLzhTUkl2OUZpbFBBVkNML2haUWkvOVFpWW9EQVVJQUFDTEFHaGVML1JKRUpjQWFGNHYrRWtTQkE4QWFpLzhTUkl2OUZpbFBBVkNML2haUWkvOVFpVUlBQUlrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
