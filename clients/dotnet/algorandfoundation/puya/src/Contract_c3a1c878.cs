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

namespace Arc56.Generated.algorandfoundation.puya.Contract_c3a1c878
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYXBwZW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1vZGlmeSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcpW10iLCJzdHJ1Y3QiOiJHZXRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiT3B0SW4iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NjUsNTU0LDYyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNyw1MDIsNjE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nbG9iIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Myw1MzAsNjIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sb2MgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg1LDU4Niw2MzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1hcCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDNdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBib3ggPT0gZ2xvYmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgbG9jYWwgPT0gZ2xvYmFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgbWFwID09IGdsb2JhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaWIzZ2lJQ0puYkc5aUlpQWliRzlqSWlBd2VEQXdNREFnSW0xaGNDSWdNSGd3TURBeU1EQXdNREF3TURBd01EQXdNREF3TVRBd01HRXdNREF6TmpJMk1UZGhJREI0TURBd09EWmtObVkyTkRZNU5qWTJPVFkxTmpRS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROVEkyWlRoaVltWWdNSGc1TldabFpqRXpaQ0F3ZURCak1qazBORFJpSUM4dklHMWxkR2h2WkNBaVlYQndaVzVrS0NsMmIybGtJaXdnYldWMGFHOWtJQ0p0YjJScFpua29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkQ2dwS0hWcGJuUTJOQ3h6ZEhKcGJtY3BXMTBpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaGNIQmxibVFnYlc5a2FXWjVJR2RsZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1qb0tJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3lNZ29nSUNBZ0x5OGdZMnhoYzNNZ1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSE4zYVhSamFDQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV6SUcxaGFXNWZiM0IwWDJsdVFERTBDaUFnSUNCbGNuSUtDbTFoYVc1ZmIzQjBYMmx1UURFME9nb2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkS1FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJ6Wld4bUxtZHNiMkl1ZG1Gc2RXVWdQU0JOZVVGeWNtRjVLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWRzYjJJaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVWdQU0JOZVVGeWNtRjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJ6Wld4bUxtZHNiMkl1ZG1Gc2RXVWdQU0JOZVVGeWNtRjVLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1RYbEJjbkpoZVNncENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJSE5sYkdZdWJHOWpXMVI0Ymk1elpXNWtaWEpkSUQwZ1RYbEJjbkpoZVNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzYjJNaUNpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklITmxiR1l1WjJ4dllpNTJZV3gxWlNBOUlFMTVRWEp5WVhrb0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNREFLSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnYzJWc1ppNXNiMk5iVkhodUxuTmxibVJsY2wwZ1BTQk5lVUZ5Y21GNUtDa0tJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdjMlZzWmk1dFlYQmJWSGh1TG5ObGJtUmxjbDBnUFNCTmVVRnljbUY1S0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW0xaGNDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdjMlZzWmk1bmJHOWlMblpoYkhWbElEMGdUWGxCY25KaGVTZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TUFvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCelpXeG1MbTFoY0Z0VWVHNHVjMlZ1WkdWeVhTQTlJRTE1UVhKeVlYa29LUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCQVlYSmpOQzVpWVhKbGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpQY0hSSmJpSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE16b0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVYM0psWVdSZlpIbHVZVzFwWTE5bGJHVnRaVzUwS0dGeWNtRjVPaUJpZVhSbGN5d2dhVzVrWlhnNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtUjVibUZ0YVdOZllYSnlZWGxmY21WaFpGOWtlVzVoYldsalgyVnNaVzFsYm5RNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDMEtJQ0FnSUhObGJHVmpkQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1gzQjFlV0ZmYkdsaUxtRnlZelF1WkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwS0dGeWNtRjVPaUJpZVhSbGN5d2dibVYzWDJobFlXUmZZVzVrWDNSaGFXdzZJR0o1ZEdWekxDQnVaWGRmYVhSbGJYTmZZMjkxYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWREb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUEwQ2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTBDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFNUW9LWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5bWIzSmZhR1ZoWkdWeVFEVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkdsbklEUUtJQ0FnSUR3S0lDQWdJR0o2SUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTlFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZlptOXlYMmhsWVdSbGNrQTFDZ3BrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURnNkNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRDaHpiM1Z5WTJVNklHSjVkR1Z6TENCdVpYZGZhWFJsYlRvZ1lubDBaWE1zSUdsdVpHVjRPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BrZVc1aGJXbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhOMVluTjBjbWx1WnlBd0lESUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd01nb2dJQ0FnTFFvZ0lDQWdZMjkyWlhJZ053b2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmpiM1psY2lBeUNncGtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURVS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05nb2dJQ0FnS3dvZ0lDQWdaR2xuSURVS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F5Q2dwa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ2NHOXdDaUFnSUNCaWRYSjVJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5OMFlYUmxYMjExZEdGMGFXOXVjeTVqYjI1MGNtRmpkQzVEYjI1MGNtRmpkQzVoY0hCbGJtUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoY0hCbGJtUTZDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE5sYkdZdVoyeHZZaTUyWVd4MVpTNWhjSEJsYm1Rb2MzUnlkV04wTG1OdmNIa29LU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm5iRzlpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHNiMklnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF3TWpBd01EQXdNREF3TURBd01EQXdNREV3TURCaE1EQXdNell5TmpFM1lRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm5iRzlpSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOYlZIaHVMbk5sYm1SbGNsMHVZWEJ3Wlc1a0tITjBjblZqZEM1amIzQjVLQ2twQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc2IyTWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzYjJNZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklITmxiR1l1WjJ4dllpNTJZV3gxWlM1aGNIQmxibVFvYzNSeWRXTjBMbU52Y0hrb0tTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREF5TURBd01EQXdNREF3TURBd01EQXdNVEF3TUdFd01EQXpOakkyTVRkaENpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklITmxiR1l1Ykc5alcxUjRiaTV6Wlc1a1pYSmRMbUZ3Y0dWdVpDaHpkSEoxWTNRdVkyOXdlU2dwS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc2IyTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbExtRndjR1Z1WkNoemRISjFZM1F1WTI5d2VTZ3BLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOTRJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QnpaV3htTG1kc2IySXVkbUZzZFdVdVlYQndaVzVrS0hOMGNuVmpkQzVqYjNCNUtDa3BDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF3TWpBd01EQXdNREF3TURBd01EQXdNREV3TURCaE1EQXdNell5TmpFM1lRb2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1aGNIQmxibVFvYzNSeWRXTjBMbU52Y0hrb0tTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6ZEdGMFpWOXRkWFJoZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXViV0Z3VzFSNGJpNXpaVzVrWlhKZExtRndjR1Z1WkNoemRISjFZM1F1WTI5d2VTZ3BLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWliV0Z3SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xaGNDQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNW5iRzlpTG5aaGJIVmxMbUZ3Y0dWdVpDaHpkSEoxWTNRdVkyOXdlU2dwS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd01ESXdNREF3TURBd01EQXdNREF3TURBeE1EQXdZVEF3TURNMk1qWXhOMkVLSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYzJWc1ppNXRZWEJiVkhodUxuTmxibVJsY2wwdVlYQndaVzVrS0hOMGNuVmpkQzVqYjNCNUtDa3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1emRHRjBaVjl0ZFhSaGRHbHZibk11WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1Ylc5a2FXWjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYlc5a2FXWjVPZ29nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJ6Wld4bUxtZHNiMkl1ZG1Gc2RXVmJNRjB1WW1GNklEMGdZWEpqTkM1VGRISnBibWNvSW0xdlpHbG1hV1ZrSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0puYkc5aUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWRzYjJJZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBNE5tUTJaalkwTmprMk5qWTVOalUyTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm5iRzlpSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z2MyVnNaaTVzYjJOYlZIaHVMbk5sYm1SbGNsMWJNRjB1WW1GNklEMGdZWEpqTkM1VGRISnBibWNvSW0xdlpHbG1hV1ZrSWlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteHZZeUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14dll5QmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnTHk4Z2MzUmhkR1ZmYlhWMFlYUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QnpaV3htTG1kc2IySXVkbUZzZFdWYk1GMHVZbUY2SUQwZ1lYSmpOQzVUZEhKcGJtY29JbTF2WkdsbWFXVmtJaWtLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBNE5tUTJaalkwTmprMk5qWTVOalUyTkFvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCelpXeG1MbXh2WTF0VWVHNHVjMlZ1WkdWeVhWc3dYUzVpWVhvZ1BTQmhjbU0wTGxOMGNtbHVaeWdpYlc5a2FXWnBaV1FpS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnNiMk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6ZEdGMFpWOXRkWFJoZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxXekJkTG1KaGVpQTlJR0Z5WXpRdVUzUnlhVzVuS0NKdGIyUnBabWxsWkNJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNnZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lDOHZJSE4wWVhSbFgyMTFkR0YwYVc5dWN5OWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnYzJWc1ppNW5iRzlpTG5aaGJIVmxXekJkTG1KaGVpQTlJR0Z5WXpRdVUzUnlhVzVuS0NKdGIyUnBabWxsWkNJcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdPRFprTm1ZMk5EWTVOalkyT1RZMU5qUUtJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdWYk1GMHVZbUY2SUQwZ1lYSmpOQzVUZEhKcGJtY29JbTF2WkdsbWFXVmtJaWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJSE5sYkdZdWJXRndXMVI0Ymk1elpXNWtaWEpkV3pCZExtSmhlaUE5SUdGeVl6UXVVM1J5YVc1bktDSnRiMlJwWm1sbFpDSXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnRZWEFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGd0lHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxZV1JmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJSE5sYkdZdVoyeHZZaTUyWVd4MVpWc3dYUzVpWVhvZ1BTQmhjbU0wTGxOMGNtbHVaeWdpYlc5a2FXWnBaV1FpS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01EZzJaRFptTmpRMk9UWTJOamsyTlRZMENpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklITmxiR1l1YldGd1cxUjRiaTV6Wlc1a1pYSmRXekJkTG1KaGVpQTlJR0Z5WXpRdVUzUnlhVzVuS0NKdGIyUnBabWxsWkNJcENpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1emRHRjBaVjl0ZFhSaGRHbHZibk11WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1WjJWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwT2dvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCaE1TQTlJSE5sYkdZdVoyeHZZaTUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0puYkc5aUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWRzYjJJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6ZEdGMFpWOXRkWFJoZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdFeUlEMGdjMlZzWmk1c2IyTmJWSGh1TG5ObGJtUmxjbDB1WTI5d2VTZ3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkc5aklnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViRzlqSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzNSaGRHVmZiWFYwWVhScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCaE15QTlJSE5sYkdZdVltOTRMblpoYkhWbExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0SUdWNGFYTjBjd29nSUNBZ0x5OGdjM1JoZEdWZmJYVjBZWFJwYjI1ekwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJoTkNBOUlITmxiR1l1YldGd1cxUjRiaTV6Wlc1a1pYSmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJXRndJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVhBZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpkR0YwWlY5dGRYUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNU0E5UFNCaE1pd2dJbVY0Y0dWamRHVmtJR3h2WTJGc0lEMDlJR2RzYjJKaGJDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdiRzlqWVd3Z1BUMGdaMnh2WW1Gc0NpQWdJQ0F2THlCemRHRjBaVjl0ZFhSaGRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCaE1TQTlQU0JoTXl3Z0ltVjRjR1ZqZEdWa0lHSnZlQ0E5UFNCbmJHOWlZV3dpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdKdmVDQTlQU0JuYkc5aVlXd0tJQ0FnSUM4dklITjBZWFJsWDIxMWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdZWE56WlhKMElHRXhJRDA5SUdFMExDQWlaWGh3WldOMFpXUWdiV0Z3SUQwOUlHZHNiMkpoYkNJS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJRzFoY0NBOVBTQm5iRzlpWVd3S0lDQWdJQzh2SUhOMFlYUmxYMjExZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lIQTJKdmVBUm5iRzlpQTJ4dll3SUFBQU50WVhBUkFBSUFBQUFBQUFBQUFRQUtBQU5pWVhvS0FBaHRiMlJwWm1sbFpERWJRUUFrTVJrVVJERVlSSUlEQkZKdWk3OEVsZjd4UFFRTUtVUkxOaG9BamdNQlVBR1JBZ0lBTVJtTkFnQWVBQUVBTVJoRUtTdG5LTHhJS0N1L01RQXFLMlluQkRFQVVFbThTQ3UvSTBNeEdCUkRpZ0lCaS81WEFnQ0wvaUpaaS84a0Mwc0NURmxMQWhXTC95TUlTU1FMU3dWTVdVOEVUd0lKVFZLSmlnTUJpLzBpV1VtTC93Z1dWd1lBVEl2OVZ3SUFUQ1FMVEl2L0pBdE9BaUpPQklzQVN3SU1RUUFiU1lzQVNVNENXVXNFQ0JaWEJnQlBCVXhRVGdRa0NJd0FRdi9kU1JWTUlvd0Fpd0JMQkF4QkFCeUwvb3NBU1U0Q1dVc0RDQlpYQmdCUEJreFFUZ1VrQ0l3QVF2L2NUZ0pTVHdKTVVJditGWXYrVHdOUEFsSlFUSW1LQXdHTC9WRUFBa2tYaS8xWEFnQ0wvaFZPQTBrVmkvOGpDQ1FMU3dKTEFWbExCSXYvQ1NNSlN3Tk9BazJML3lRTFN3Uk1XVW9KVGdkTEJDSlBBbEtML2xCUEJFOENUd1JTVUU0Q1RDUUxUZ0pKU3dNTVFRQVpURWxMQWxsTEJnaExCUWtXVndZQVN3Sk1YVXdrQ0VMLzRFaEZBVkNNQUlraUtXVkVKd1VqaVA3N0tVeG5NUUJKSWlwalJDY0ZJNGorNnlwTVppaStSQ2NGSTRqKzN5aThTQ2hNdnljRU1RQlFTYjVFSndVamlQN0xTd0c4U0w4alF5SXBaVVJKSW9qK2tVa2xXU0pNV0NjR1VDS0kvekVwVEdjeEFFa2lLbU5FU1NLSS9uVkpKVmtpVEZnbkJsQWlpUDhWS2t4bUtMNUVTU0tJL2wxSkpWa2lURmduQmxBaWlQNzlLTHhJS0V5L0p3UXhBRkJKdmtSSklvaitQVWtsV1NKTVdDY0dVQ0tJL3QxTEFieEl2eU5ESWlsbFJERUFJaXBqUkNpK1JDY0VNUUJRdmtSTEEwOERFa1JMQWs4Q0VrUkxBUkpFZ0FRVkgzeDFURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
