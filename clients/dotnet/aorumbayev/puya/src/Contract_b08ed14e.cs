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

namespace Arc56.Generated.aorumbayev.puya.Contract_b08ed14e
{


    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetReturn);
                }
                public bool Equals(GetReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetReturn left, GetReturn right)
                {
                    return EqualityComparer<GetReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetReturn left, GetReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Append(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 110, 139, 191 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 110, 139, 191 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Modify(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 254, 241, 61 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Modify_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 254, 241, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetReturn[]> Get(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 41, 68, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetReturn>(x => Structs.GetReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> Get_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 41, 68, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYXBwZW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1vZGlmeSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcpW10iLCJzdHJ1Y3QiOiJHZXRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiT3B0SW4iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NTcsNjA0LDY0Nyw2OThdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2LDExNywxMjldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OSwxMjAsMTMyLDE1MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTQsNjM0LDc0MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Miw1NDQsNzMyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nbG9iIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3NSw1OTEsNzM4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sb2MgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIxLDY4NSw3NDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1hcCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjBdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBib3ggPT0gZ2xvYmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzU0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgbG9jYWwgPT0gZ2xvYmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgbWFwID09IGdsb2JhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCMFpYTjBYMk5oYzJWekxuTjBZWFJsWDIxMWRHRjBhVzl1Y3k1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUE0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ppYjNnaUlDSm5iRzlpSWlBaWJHOWpJaUF3ZURBd01EQWdJbTFoY0NJZ01IZ3dNREF5TURBd01EQXdNREF3TURBd01EQXdNVEF3TUdFd01EQXpOakkyTVRkaElEQjRNREF3T0Raa05tWTJORFk1TmpZMk9UWTFOalFLSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBNENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5USTJaVGhpWW1ZZ01IZzVOV1psWmpFelpDQXdlREJqTWprME5EUmlJQzh2SUcxbGRHaHZaQ0FpWVhCd1pXNWtLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnRiMlJwWm5rb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRDZ3BLSFZwYm5RMk5DeHpkSEpwYm1jcFcxMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyRndjR1Z1WkY5eWIzVjBaVUExSUcxaGFXNWZiVzlrYVdaNVgzSnZkWFJsUURZZ2JXRnBibDluWlhSZmNtOTFkR1ZBTndvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJqYkdGemN5QkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmJXOWthV1o1WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6ZEdGMFpWOXRkWFJoZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUcxdlpHbG1lUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjSEJsYm1SZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1lYQndaVzVrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBNE9nb2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjM2RwZEdOb0lHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEFnYldGcGJsOXZjSFJmYVc1QU9Rb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtDbTFoYVc1ZmIzQjBYMmx1UURrNkNpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklFQmhjbU0wTG1KaGNtVnRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs5d2RFbHVJbDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnYjNCMFgybHVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFd09nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUW9ZWEp5WVhsZmFYUmxiWE5mWTI5MWJuUTZJSFZwYm5RMk5Dd2dZWEp5WVhsZmFHVmhaRjloYm1SZmRHRnBiRG9nWW5sMFpYTXNJRzVsZDE5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMExDQnVaWGRmYUdWaFpGOWhibVJmZEdGcGJEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTVRvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdZaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWm05eVgyaGxZV1JsY2tBeENncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0ExT2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURVS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFPRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUY5d2RYbGhYMnhwWWk1aGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblFvYzI5MWNtTmxPaUJpZVhSbGN5d2dibVYzWDJsMFpXMDZJR0o1ZEdWekxDQnBibVJsZURvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1pIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWREb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lDMEtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0NtUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTFDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURJS0NtUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbk4wWVhSbFgyMTFkR0YwYVc5dWN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNXZjSFJmYVc0b0tTQXRQaUIyYjJsa09ncHZjSFJmYVc0NkNpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklITmxiR1l1WjJ4dllpNTJZV3gxWlNBOUlFMTVRWEp5WVhrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVoyeHZZaUlLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qTXlDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlNBOUlFMTVRWEp5WVhrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdNQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCelpXeG1MbXh2WTF0VWVHNHVjMlZ1WkdWeVhTQTlJRTE1UVhKeVlYa29LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJHOWpJZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3TURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z2MyVnNaaTV0WVhCYlZIaHVMbk5sYm1SbGNsMGdQU0JOZVVGeWNtRjVLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTFoY0NJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5OMFlYUmxYMjExZEdGMGFXOXVjeTVqYjI1MGNtRmpkQzVEYjI1MGNtRmpkQzVoY0hCbGJtUW9LU0F0UGlCMmIybGtPZ3BoY0hCbGJtUTZDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE5sYkdZdVoyeHZZaTUyWVd4MVpTNWhjSEJsYm1Rb2MzUnlkV04wTG1OdmNIa29LU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm5iRzlpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHNiMklnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBd01qQXdNREF3TURBd01EQXdNREF3TURFd01EQmhNREF3TXpZeU5qRTNZUW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kc2IySWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMXRVZUc0dWMyVnVaR1Z5WFM1aGNIQmxibVFvYzNSeWRXTjBMbU52Y0hrb0tTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXh2WXlJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHZZeUJsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01EQXlNREF3TURBd01EQXdNREF3TURBd01UQXdNR0V3TURBek5qSTJNVGRoQ2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJHOWpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlQzUyWVd4MVpTNWhjSEJsYm1Rb2MzUnlkV04wTG1OdmNIa29LU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZlQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURBeU1EQXdNREF3TURBd01EQXdNREF3TVRBd01HRXdNREF6TmpJMk1UZGhDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklITmxiR1l1YldGd1cxUjRiaTV6Wlc1a1pYSmRMbUZ3Y0dWdVpDaHpkSEoxWTNRdVkyOXdlU2dwS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYldGd0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMWhjQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREF5TURBd01EQXdNREF3TURBd01EQXdNVEF3TUdFd01EQXpOakkyTVRkaENpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXpkR0YwWlY5dGRYUmhkR2x2Ym5NdVkyOXVkSEpoWTNRdVEyOXVkSEpoWTNRdWJXOWthV1o1S0NrZ0xUNGdkbTlwWkRvS2JXOWthV1o1T2dvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCelpXeG1MbWRzYjJJdWRtRnNkV1ZiTUYwdVltRjZJRDBnWVhKak5DNVRkSEpwYm1jb0ltMXZaR2xtYVdWa0lpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbmJHOWlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kc2IySWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdNRGcyWkRabU5qUTJPVFkyTmprMk5UWTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kc2IySWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJ6Wld4bUxteHZZMXRVZUc0dWMyVnVaR1Z5WFZzd1hTNWlZWG9nUFNCaGNtTTBMbE4wY21sdVp5Z2liVzlrYVdacFpXUWlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkc5aklnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViRzlqSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQTRObVEyWmpZME5qazJOalk1TmpVMk5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzYjJNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsV3pCZExtSmhlaUE5SUdGeVl6UXVVM1J5YVc1bktDSnRiMlJwWm1sbFpDSXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWIzZ2daWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdNRGcyWkRabU5qUTJPVFkyTmprMk5UWTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QnpaV3htTG0xaGNGdFVlRzR1YzJWdVpHVnlYVnN3WFM1aVlYb2dQU0JoY21NMExsTjBjbWx1WnlnaWJXOWthV1pwWldRaUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJXRndJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFoY0NCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xTQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREF3T0Raa05tWTJORFk1TmpZMk9UWTFOalFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1emRHRjBaVjl0ZFhSaGRHbHZibk11WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1WjJWMEtDa2dMVDRnWW5sMFpYTTZDbWRsZERvS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1lURWdQU0J6Wld4bUxtZHNiMkl1ZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWjJ4dllpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuYkc5aUlHVjRhWE4wY3dvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCaE1pQTlJSE5sYkdZdWJHOWpXMVI0Ymk1elpXNWtaWEpkTG1OdmNIa29LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14dll5SUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXh2WXlCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1lUTWdQU0J6Wld4bUxtSnZlQzUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2ZUNCbGVHbHpkSE1LSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnWVRRZ1BTQnpaV3htTG0xaGNGdFVlRzR1YzJWdVpHVnlYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMWhjQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGd0lHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEVnUFQwZ1lUSXNJQ0psZUhCbFkzUmxaQ0JzYjJOaGJDQTlQU0JuYkc5aVlXd2lDaUFnSUNCa2FXY2dNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR3h2WTJGc0lEMDlJR2RzYjJKaGJBb2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmhjM05sY25RZ1lURWdQVDBnWVRNc0lDSmxlSEJsWTNSbFpDQmliM2dnUFQwZ1oyeHZZbUZzSWdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCaWIzZ2dQVDBnWjJ4dlltRnNDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNU0E5UFNCaE5Dd2dJbVY0Y0dWamRHVmtJRzFoY0NBOVBTQm5iRzlpWVd3aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0J0WVhBZ1BUMGdaMnh2WW1Gc0NpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklISmxkSFZ5YmlCaE1Rb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUVDQ0NZSEEySnZlQVJuYkc5aUEyeHZZd0lBQUFOdFlYQVJBQUlBQUFBQUFBQUFBUUFLQUFOaVlYb0tBQWh0YjJScFptbGxaREViUVFCTGdnTUVVbTZMdndTVi92RTlCQXdwUkVzMkdnQ09Bd0FqQUJjQUFpSkRNUmtVUkRFWVJJZ0Njb0FFRlI5OGRVeFFzQ05ETVJrVVJERVlSSWdCb1NORE1Sa1VSREVZUklnQk9TTkRNUm1OQWdBTEFBTkMvOFl4R0VTSUFRMGpRekVZRkVRalE0b0VBWUFBU1l2K0pBdUwvQ1FMSW9zRWl3TU1RUUFjaS8yTEJFbE9BbG1MQWdnV1Z3WUNpd0ZNVUl3QkpBaU1CRUwvM0l2OUZZd0FJb3dFaXdTTEFneEJBQnlMLzRzRVNVNENXWXNBQ0JaWEJnS0xBVXhRakFFa0NJd0VRdi9jaS95TC9nZ1dWd1lDaXdGUWkvMkxBNHNBVWxDTC94V0wvNHNDVHdKU1VJd0FpWW9EQVl2OVVRQUNTUmVML1ZjQ0FJdi9KQXRMQVV4WmkvOGpDQ1FMU1U0RVN3Sk1XVXNDRlVzRWkvOEpJd2xMQVU4RFR3Sk5TVXNEQ1U0RmkvNFZUZ1ZMQXlKUEJGS0wvbEJQQTA4Q1R3TlNVRXdrQzRzQml3VU1RUUFnaXdSSml3RkpUZ05aaXdNSWl3SUpGbGNHQWtzQ1RGMk1CQ1FJakFGQy85aUxBSXNFVUl3QWlTa3JaeWk4U0NncnZ6RUFLaXRtSndReEFGQkp2RWdydjRraUtXVkVTU0paVEZjQ0FDTW5CWWorMFNsTVp6RUFTU0lxWTBSSklsbE1Wd0lBSXljRmlQNjZLa3htS0w1RVNTSlpURmNDQUNNbkJZaitweWk4U0NoTXZ5Y0VNUUJRU2I1RVNTSlpURmNDQUNNbkJZaitqRXNCdkVpL2lTSXBaVVJKVndJQVNTSlpTd0lpV1NNSlN3SVZTd01rV1U4Q1RWSkpKVmtpVEZnbkJsQWlpUDdlS1V4bk1RQkpJaXBqUkVsWEFnQkpJbGxMQWlKWkl3bExBaFZMQXlSWlR3Sk5Va2tsV1NKTVdDY0dVQ0tJL3E4cVRHWW92a1JKVndJQVNTSlpTd0lpV1NNSlN3SVZTd01rV1U4Q1RWSkpKVmtpVEZnbkJsQWlpUDZFS0x4SUtFeS9Kd1F4QUZCSnZrUkpWd0lBU1NKWlN3SWlXU01KU3dJVlN3TWtXVThDVFZKSkpWa2lURmduQmxBaWlQNVJTd0c4U0wrSklpbGxSREVBSWlwalJDaStSQ2NFTVFCUXZrUkxBMDhERWtSTEFrOENFa1JMQVJKRWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
