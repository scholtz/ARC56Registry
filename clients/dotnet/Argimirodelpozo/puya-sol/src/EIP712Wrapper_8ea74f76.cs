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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EIP712Wrapper_8ea74f76
{


    public class EIP712WrapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EIP712WrapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Eip712DomainReturn : AVMObjectType
            {
                public byte[] Fields { get; set; }

                public string Name { get; set; }

                public string Version { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ChainId { get; set; }

                public Algorand.Address VerifyingContract { get; set; }

                public byte[] Salt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Extensions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    vFields.From(Fields);
                    ret.AddRange(vFields.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.From(Version);
                    stringRef[ret.Count] = vVersion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChainId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vChainId.From(ChainId);
                    ret.AddRange(vChainId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vVerifyingContract.From(VerifyingContract);
                    ret.AddRange(vVerifyingContract.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSalt.From(Salt);
                    ret.AddRange(vSalt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    vExtensions.From(Extensions);
                    ret.AddRange(vExtensions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Eip712DomainReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Eip712DomainReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    count = vFields.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFields = vFields.ToValue();
                    if (valueFields is byte[] vFieldsValue) { ret.Fields = vFieldsValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexVersion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.Decode(bytes.Skip(indexVersion + prefixOffset).ToArray());
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is string vVersionValue) { ret.Version = vVersionValue; }
                    var vChainId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vChainId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ChainId = vChainId;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVerifyingContract.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifyingContract = vVerifyingContract.ToValue();
                    if (valueVerifyingContract is Algorand.Address vVerifyingContractValue) { ret.VerifyingContract = vVerifyingContractValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSalt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSalt = vSalt.ToValue();
                    if (valueSalt is byte[] vSaltValue) { ret.Salt = vSaltValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    count = vExtensions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExtensions = vExtensions.ToValue();
                    if (valueExtensions is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vExtensionsValue) { ret.Extensions = vExtensionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Eip712DomainReturn);
                }
                public bool Equals(Eip712DomainReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return EqualityComparer<Eip712DomainReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> GetDomainSeparator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 159, 33, 25 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetDomainSeparator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 159, 33, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev See: https://eips.ethereum.org/EIPS/eip-5267
        ///</summary>
        public async Task<Structs.Eip712DomainReturn> Eip712Domain(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 48, 46, 0 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Eip712DomainReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Eip712Domain_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 48, 46, 0 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRUlQNzEyV3JhcHBlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJlaXA3MTJEb21haW5SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZHMiLCJ0eXBlIjoiYnl0ZVsxXSJ9LHsibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidmVyc2lvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjaGFpbklkIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJ2ZXJpZnlpbmdDb250cmFjdCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic2FsdCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImV4dGVuc2lvbnMiLCJ0eXBlIjoidWludDI1NltdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldERvbWFpblNlcGFyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlaXA3MTJEb21haW4iLCJkZXNjIjoiQGRldiBTZWU6IGh0dHBzOi8vZWlwcy5ldGhlcmV1bS5vcmcvRUlQUy9laXAtNTI2NyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVsxXSxzdHJpbmcsc3RyaW5nLHVpbnQyNTYsYWRkcmVzcyxieXRlWzMyXSx1aW50MjU2W10pIiwic3RydWN0IjoiZWlwNzEyRG9tYWluUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjV9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRDaGFpbklkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWREb21haW5TZXBhcmF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjEyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2NhY2hlZE5hbWVIYXNoIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRUaGlzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRWZXJzaW9uSGFzaCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSVWxRTnpFeVYzSmhjSEJsY2k1emIyd3VSVWxRTnpFeVYzSmhjSEJsY2k1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRE15SURBZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VDQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnSWw5allXTm9aV1JVYUdseklpQWlYMk5oWTJobFpFTm9ZV2x1U1dRaUlDSmZZMkZqYUdWa1RtRnRaVWhoYzJnaUlDSmZZMkZqYUdWa1ZtVnljMmx2YmtoaGMyZ2lJQ0pmWTJGamFHVmtSRzl0WVdsdVUyVndZWEpoZEc5eUlpQXdlRGhpTnpOak0yTTJPV0ppT0dabE0yUTFNVEpsWTJNMFkyWTNOVGxqWXpjNU1qTTVaamRpTVRjNVlqQm1abUZqWVdFNVlUYzFaRFV5TW1Jek9UUXdNR1lnTUhnNU1HVTJPR0kyTnpJNVlXTXpNamd3TlRBMk1USTNZV1F4T1dSbFpHWmxPR1poWVRjNVl6VTFZemMzTUdReVlUUTBNREJqWkdVME4yRXpZelV6TXpobUlEQjRNVFV4Wmpkak56VUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhCdUlETUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKZlkyRmphR1ZrVkdocGN5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmZZMkZqYUdWa1EyaGhhVzVKWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKZlkyRmphR1ZrVG1GdFpVaGhjMmdpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDJOaFkyaGxaRlpsY25OcGIyNUlZWE5vSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEWWdMeThnSWw5allXTm9aV1JFYjIxaGFXNVRaWEJoY21GMGIzSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlYMk5oWTJobFpGUm9hWE1pQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QWlYMk5oWTJobFpFTm9ZV2x1U1dRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWW5WeWVTQXlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlNU0lLSUNBZ0lHSjFjbmtnTWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjFjbmtnTkFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWTZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFPQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjFjbmtnTVFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEazZDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZZMkZqYUdWa1RtRnRaVWhoYzJnaUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOWpZV05vWldSV1pYSnphVzl1U0dGemFDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Rb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEaGlOek5qTTJNMk9XSmlPR1psTTJRMU1USmxZMk0wWTJZM05UbGpZemM1TWpNNVpqZGlNVGM1WWpCbVptRmpZV0U1WVRjMVpEVXlNbUl6T1RRd01HWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNCaWRYSjVJRE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTRPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHdGxZMk5oYXpJMU5nb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTlRvS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnNU1HVTJPR0kyTnpJNVlXTXpNamd3TlRBMk1USTNZV1F4T1dSbFpHWmxPR1poWVRjNVl6VTFZemMzTUdReVlUUTBNREJqWkdVME4yRXpZelV6TXpobUNpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdJeE9XWXlNVEU1SURCNFlXTXpNREpsTURBZ0x5OGdiV1YwYUc5a0lDSm5aWFJFYjIxaGFXNVRaWEJoY21GMGIzSW9LV0o1ZEdWYk16SmRJaXdnYldWMGFHOWtJQ0psYVhBM01USkViMjFoYVc0b0tTaGllWFJsV3pGZExITjBjbWx1Wnl4emRISnBibWNzZFdsdWRESTFOaXhoWkdSeVpYTnpMR0o1ZEdWYk16SmRMSFZwYm5ReU5UWmJYU2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCblpYUkViMjFoYVc1VFpYQmhjbUYwYjNJZ1pXbHdOekV5Ukc5dFlXbHVDaUFnSUNCbGNuSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJVbFFOekV5VjNKaGNIQmxjaTV6YjJ3dVJVbFFOekV5VjNKaGNIQmxjaTVuWlhSRWIyMWhhVzVUWlhCaGNtRjBiM0piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkViMjFoYVc1VFpYQmhjbUYwYjNJNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdZbm9nWjJWMFJHOXRZV2x1VTJWd1lYSmhkRzl5WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0JqWVd4c2MzVmlJRjlpZFdsc1pFUnZiV0ZwYmxObGNHRnlZWFJ2Y2dvZ0lDQWdZblZ5ZVNBeENncG5aWFJFYjIxaGFXNVRaWEJoY21GMGIzSmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEVSdmJXRnBibE5sY0dGeVlYUnZjbDlsYkhObFgySnZaSGxBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pmWTJGamFHVmtSRzl0WVdsdVUyVndZWEpoZEc5eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVgyTmhZMmhsWkVOb1lXbHVTV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjlqWVdOb1pXUkRhR0ZwYmtsa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDlqWVdOb1pXUlVhR2x6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmWTJGamFHVmtWR2hwY3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0k5UFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaVBUMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWjJWMFJHOXRZV2x1VTJWd1lYSmhkRzl5WDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ1kyRnNiSE4xWWlCZlluVnBiR1JFYjIxaGFXNVRaWEJoY21GMGIzSUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQm5aWFJFYjIxaGFXNVRaWEJoY21GMGIzSmZZV1owWlhKZmFXWmZaV3h6WlVBMkNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBWSlVEY3hNbGR5WVhCd1pYSXVjMjlzTGtWSlVEY3hNbGR5WVhCd1pYSXVaV2x3TnpFeVJHOXRZV2x1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pXbHdOekV5Ukc5dFlXbHVPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQm1NREEyTnpBd056TUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR3h2WVdSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRGMyTURBd1lUVTBOalUzTXpjME5EUTJaalprTmpFMk9UWmxNREF3TVRNeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOUZTVkEzTVRKWGNtRndjR1Z5TG5OdmJDNUZTVkEzTVRKWGNtRndjR1Z5TGw5aWRXbHNaRVJ2YldGcGJsTmxjR0Z5WVhSdmNpZ3BJQzArSUdKNWRHVnpPZ3BmWW5WcGJHUkViMjFoYVc1VFpYQmhjbUYwYjNJNkNpQWdJQ0J3Y205MGJ5QXdJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCaWVpQmZZblZwYkdSRWIyMWhhVzVUWlhCaGNtRjBiM0pmWld4elpWOWliMlI1UURJS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnNU1HVTJPR0kyTnpJNVlXTXpNamd3TlRBMk1USTNZV1F4T1dSbFpHWmxPR1poWVRjNVl6VTFZemMzTUdReVlUUTBNREJqWkdVME4yRXpZelV6TXpobUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdNNE9XVm1aR0ZoTlRSak1HWXlNR00zWVdSbU5qRXlPRGd5WkdZd09UVXdaalZoT1RVeE5qTTNaVEF6TURkalpHTmlOR00yTnpKbU1qazRZamhpWXpZS0NsOWlkV2xzWkVSdmJXRnBibE5sY0dGeVlYUnZjbDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE9HSTNNMk16WXpZNVltSTRabVV6WkRVeE1tVmpZelJqWmpjMU9XTmpOemt5TXpsbU4ySXhOemxpTUdabVlXTmhZVGxoTnpWa05USXlZak01TkRBd1pnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWlkV2xzWkVSdmJXRnBibE5sY0dGeVlYUnZjbDlsYkhObFgySnZaSGxBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pmWTJGamFHVmtUbUZ0WlVoaGMyZ2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyTmhZMmhsWkU1aGJXVklZWE5vSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOWpZV05vWldSV1pYSnphVzl1U0dGemFDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyTmhZMmhsWkZabGNuTnBiMjVJWVhOb0lHVjRhWE4wY3dvZ0lDQWdZaUJmWW5WcGJHUkViMjFoYVc1VFpYQmhjbUYwYjNKZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJVbFFOekV5VjNKaGNIQmxjaTV6YjJ3dVJVbFFOekV5VjNKaGNIQmxjaTVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRElBQUJKZ29BSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDMTlqWVdOb1pXUlVhR2x6RGw5allXTm9aV1JEYUdGcGJrbGtEMTlqWVdOb1pXUk9ZVzFsU0dGemFCSmZZMkZqYUdWa1ZtVnljMmx2YmtoaGMyZ1dYMk5oWTJobFpFUnZiV0ZwYmxObGNHRnlZWFJ2Y2lDTGM4UEdtN2orUFZFdXpFejNXY3g1STU5N0Y1c1Arc3FwcDExU0t6bEFEeUNRNW90bkthd3lnRkJoSjYwWjN0L28rcWVjVmNkdzBxUkFETjVIbzhVemp3UVZIM3gxSTBjRE1SaEFBSXNxS0djcktHY25CQ2huSndVb1p5Y0dLR2NxTWdwbk1nZ1dLMHhuS0VVQ0tFQUFCWUFCTVVVQ0tFRUFXQ2xGQkNoQkFFa3BSUUVuQkVzRVp5Y0ZTd0ZuS1VVREtFQUFMaklLSXE5SlN3WlFTUlVpQ1NKWUp3ZE1VRXNCU3dSUVNSVWlDU0pZVUNsUVRFOENVRWtWSWdraVdGQUNSUU1uQmtzRFp5UkRTd0VDUlFGQy83SW5DRVVFUXYra01Sa1VSREVZUklJQ0JMR2ZJUmtFckRBdUFEWWFBSTRDQUFFQVNRQWpLRUVBRFlnQWcwVUJKd2xMQVZDd0pFTWpKd1psVEVVQ1JDTXJaVVFqS21WRUl4WlBBcWdvZ0FFQlR3Sk5NZ3BQQXFnb2dBRUJUd0pOckNpb1FmL0tpQUJJUlFGQy84SW9JeklJRmpJS0lxOVBBcXVBQlE4QVp3QnpURkJNVUV4UVRENUpGU0lLRmxjR0FreFFUSUFSQUhZQUNsUmxjM1JFYjIxaGFXNEFBVEZRVEZBbkNVeFFzQ1JEaWdBQkl5aEJBRlFuQ0l3QWdDREludjJxVk1EeURIcmZZU2lDM3dsUTlhbFJZMzREQjgzTFRHY3ZLWXVMeGpJS0lxOUppd0JRU1JVaUNTSllKd2RNVUVzQlR3UlFTUlVpQ1NKWVVDbFFURThDVUVrVklna2lXRkFDVElrakp3UmxUSXdBUkNNbkJXVkVRdi9DIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
