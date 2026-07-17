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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.Arc4Tuple_d9fb5142
{


    public class Arc4TupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4TupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AddContactInfoArgContact : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static AddContactInfoArgContact Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AddContactInfoArgContact();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AddContactInfoArgContact);
                }
                public bool Equals(AddContactInfoArgContact? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AddContactInfoArgContact left, AddContactInfoArgContact right)
                {
                    return EqualityComparer<AddContactInfoArgContact>.Default.Equals(left, right);
                }
                public static bool operator !=(AddContactInfoArgContact left, AddContactInfoArgContact right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///An arc4.Tuple is a heterogeneous collection of arc4 types.
        ///</summary>
        /// <param name="contact"> AddContactInfoArgContact</param>
        public async Task<ulong> AddContactInfo(Structs.AddContactInfoArgContact contact, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 104, 193, 63 };

            var result = await base.CallApp(new List<object> { abiHandle, contact }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddContactInfo_Transactions(Structs.AddContactInfoArgContact contact, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 104, 193, 63 };

            return await base.MakeTransactionList(new List<object> { abiHandle, contact }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///An arc4.Tuple can be returned when more than one return value is needed.
        ///</summary>
        public async Task<Structs.AddContactInfoArgContact> ReturnContact(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 141, 199, 95 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AddContactInfoArgContact.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReturnContact_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 141, 199, 95 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNFR1cGxlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFkZENvbnRhY3RJbmZvQXJnQ29udGFjdCI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJhZGRfY29udGFjdF9pbmZvIiwiZGVzYyI6IkFuIGFyYzQuVHVwbGUgaXMgYSBoZXRlcm9nZW5lb3VzIGNvbGxlY3Rpb24gb2YgYXJjNCB0eXBlcy4iLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IkFkZENvbnRhY3RJbmZvQXJnQ29udGFjdCIsIm5hbWUiOiJjb250YWN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV0dXJuX2NvbnRhY3QiLCJkZXNjIjoiQW4gYXJjNC5UdXBsZSBjYW4gYmUgcmV0dXJuZWQgd2hlbiBtb3JlIHRoYW4gb25lIHJldHVybiB2YWx1ZSBpcyBuZWVkZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsc3RyaW5nLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBZGRDb250YWN0SW5mb0FyZ0NvbnRhY3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbnRhY3RfaW5mbyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnSW1OdmJuUmhZM1JmYVc1bWJ5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6UmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNamMwQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZiblJoWTNSZmFXNW1ieUE5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOXVkR0ZqZEY5cGJtWnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelJmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpjMUNpQWdJQ0F2THlCamIyNTBZV04wWDJsdVptOWZkSFZ3YkdVb0tHRnlZelF1VTNSeWFXNW5LQ0lpS1N3Z1lYSmpOQzVUZEhKcGJtY29JaUlwTENCaGNtTTBMbFZKYm5RMk5DZ3dLU2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURCak1EQXdaVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6UmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNamMwTFRJM05nb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1MFlXTjBYMmx1Wm04Z1BTQkhiRzlpWVd4VGRHRjBaU2dLSUNBZ0lDOHZJQ0FnSUNCamIyNTBZV04wWDJsdVptOWZkSFZ3YkdVb0tHRnlZelF1VTNSeWFXNW5LQ0lpS1N3Z1lYSmpOQzVUZEhKcGJtY29JaUlwTENCaGNtTTBMbFZKYm5RMk5DZ3dLU2twQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TnpJS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSVWRYQnNaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TjJZMk9HTXhNMllnTUhneU9EaGtZemMxWmlBdkx5QnRaWFJvYjJRZ0ltRmtaRjlqYjI1MFlXTjBYMmx1Wm04b0tITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBLU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsZEhWeWJsOWpiMjUwWVdOMEtDa29jM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1lXUmtYMk52Ym5SaFkzUmZhVzVtYnlCeVpYUjFjbTVmWTI5dWRHRmpkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNGdMeThnYjI0Z1pYSnliM0k2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FnSmlZZ1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ5WXpSZmRIbHdaWE11WTI5dWRISmhZM1F1UVhKak5GUjFjR3hsTG1Ga1pGOWpiMjUwWVdOMFgybHVabTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZZMjl1ZEdGamRGOXBibVp2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpSZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qYzRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0wWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJNE1Rb2dJQ0FnTHk4Z2JtRnRaU3dnWlcxaGFXd3NJSEJvYjI1bElEMGdZMjl1ZEdGamRDNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMElEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTBYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakk0TXdvZ0lDQWdMeThnWVhOelpYSjBJRzVoYldVdWJtRjBhWFpsSUQwOUlDSkJiR2xqWlNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVFXeHBZMlVpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTkY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU9EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGJXRnBiQzV1WVhScGRtVWdQVDBnSW1Gc2FXTmxRSE52YldWMGFHbHVaeTVqYjIwaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poYkdsalpVQnpiMjFsZEdocGJtY3VZMjl0SWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpSZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qZzFDaUFnSUNBdkx5QmhjM05sY25RZ2NHaHZibVVnUFQwZ1lYSmpOQzVWU1c1ME5qUW9OVFUxWHpVMU5WODFOVFVwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNakV4WkRGaFpUTUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95T0RjS0lDQWdJQzh2SUhObGJHWXVZMjl1ZEdGamRGOXBibVp2TG5aaGJIVmxJRDBnWTI5dWRHRmpkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjl1ZEdGamRGOXBibVp2SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelJmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhKak5GOTBlWEJsY3k1amIyNTBjbUZqZEM1QmNtTTBWSFZ3YkdVdWNtVjBkWEp1WDJOdmJuUmhZM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYUjFjbTVmWTI5dWRHRmpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0wWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJNU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZMjl1ZEdGamRGOXBibVp2TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOXVkR0ZqZEY5cGJtWnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmJuUmhZM1JmYVc1bWJ5QmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTVNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUFneGpiMjUwWVdOMFgybHVabThFRlI5OGRURVlRQUFVS0lBUUFBd0FEZ0FBQUFBQUFBQUFBQUFBQUdjeEcwRUFIVEVaRkVReEdFU0NBZ1IvYU1FL0JDaU54MTgyR2dDT0FnQUpBR29BTVJrVU1SZ1VFRU0yR2dGSklsbExBWUVDV1VzQ1R3SkxBbEpMQWhWTEEwOERUd0pTU3dKWEJBaFBBbGNDQUlBRlFXeHBZMlVTUkV4WEFnQ0FFMkZzYVdObFFITnZiV1YwYUdsdVp5NWpiMjBTUkVtQUNBQUFBQUFoSFJyanFFUW9Ud0puS1V4UXNDTkRJaWhsUkNsTVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
