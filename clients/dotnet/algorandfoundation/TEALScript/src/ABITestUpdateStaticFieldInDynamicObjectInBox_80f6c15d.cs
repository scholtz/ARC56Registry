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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d
{


    public class ABITestUpdateStaticFieldInDynamicObjectInBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestUpdateStaticFieldInDynamicObjectInBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AddrAddressStrString : AVMObjectType
            {
                public Algorand.Address Addr { get; set; }

                public string Str { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddr.From(Addr);
                    ret.AddRange(vAddr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStr.From(Str);
                    stringRef[ret.Count] = vStr.Encode();
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

                public static AddrAddressStrString Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AddrAddressStrString();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddr = vAddr.ToValue();
                    if (valueAddr is Algorand.Address vAddrValue) { ret.Addr = vAddrValue; }
                    var indexStr = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStr.Decode(bytes.Skip(indexStr + prefixOffset).ToArray());
                    var valueStr = vStr.ToValue();
                    if (valueStr is string vStrValue) { ret.Str = vStrValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AddrAddressStrString);
                }
                public bool Equals(AddrAddressStrString? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AddrAddressStrString left, AddrAddressStrString right)
                {
                    return EqualityComparer<AddrAddressStrString>.Default.Equals(left, right);
                }
                public static bool operator !=(AddrAddressStrString left, AddrAddressStrString right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> UpdateStaticFieldInDynamicObjectInBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 116, 67, 46 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateStaticFieldInDynamicObjectInBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 116, 67, 46 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0VXBkYXRlU3RhdGljRmllbGRJbkR5bmFtaWNPYmplY3RJbkJveCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsieyBhZGRyOiBBZGRyZXNzOyBzdHI6IHN0cmluZyB9IjpbeyJuYW1lIjoiYWRkciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3RyIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ1cGRhdGVTdGF0aWNGaWVsZEluRHluYW1pY09iamVjdEluQm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOls0LDUsNiw3LDgsOSwxMCwxMSwxMiwxM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMTQsMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzE3LDE4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMCwyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDEsNDIsNDMsNDQsNDUsNDYsNDcsNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOls0OV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOls1MCw1MSw1Miw1Myw1NCw1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTcyIn0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzIifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MiJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTcyIn0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzIifSx7InBjIjpbNjIsNjMsNjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MiJ9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTcyIn0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzIifSx7InBjIjpbNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MiJ9LHsicGMiOls2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTcyIn0seyJwYyI6WzY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzIifSx7InBjIjpbNzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MiJ9LHsicGMiOls3MSw3Miw3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTcyIn0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzMifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MyJ9LHsicGMiOls3Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6Wzc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzMifSx7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MyJ9LHsicGMiOls3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6WzgwLDgxLDgyLDgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzMifSx7InBjIjpbODQsODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MyJ9LHsicGMiOls4Niw4Nyw4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6Wzg5LDkwLDkxLDkyLDkzLDk0LDk1LDk2LDk3LDk4LDk5LDEwMCwxMDEsMTAyLDEwMywxMDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3MyJ9LHsicGMiOlsxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6WzEwOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6WzEwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6WzExMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTczIn0seyJwYyI6WzExMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzExMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzExM10sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5iTWFwKCdiTWFwJykudmFsdWUiLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzUifSx7InBjIjpbMTE0LDExNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzExNiwxMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NSJ9LHsicGMiOlsxMTgsMTE5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzUifSx7InBjIjpbMTIwLDEyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc1In0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzEzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5iTWFwKCdiTWFwJykudmFsdWUiLCJ0ZWFsIjo5MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzYifSx7InBjIjpbMTMyLDEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzEzNCwxMzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxMzYsMTM3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzYifSx7InBjIjpbMTM4LDEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzE0MCwxNDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxNDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxNDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxNDQsMTQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzYifSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzE0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzYifSx7InBjIjpbMTQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzE1MCwxNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzYifSx7InBjIjpbMTUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTc2In0seyJwYyI6WzE1M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxNTQsMTU1LDE1Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU3NiJ9LHsicGMiOlsxNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NzIifSx7InBjIjpbMTU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzE1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxNjAsMTYxLDE2MiwxNjMsMTY0LDE2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxNjYsMTY3LDE2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxNjksMTcwLDE3MSwxNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMTczXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6MTIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxNzQsMTc1LDE3NiwxNzcsMTc4LDE3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxODAsMTgxLDE4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxODMsMTg0LDE4NSwxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMTg3XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjEyOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMTg4LDE4OSwxOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMTkxLDE5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxOTMsMTk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzE5NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsxOTYsMTk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzE5OCwxOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjAwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIwMSwyMDIsMjAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIwNCwyMDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjA2LDIwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjA5LDIxMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMTEsMjEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIxM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjE1LDIxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjE4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIxOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMjAsMjIxLDIyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMjMsMjI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIyNSwyMjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjI3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMjksMjMwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIzMSwyMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1NjkifSx7InBjIjpbMjMzLDIzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9LHsicGMiOlsyMzUsMjM2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTY5In0seyJwYyI6WzIzN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTU2OSJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDbUo1ZEdWallteHZZMnNnTUhnd01EQTBOakkwWkRZeE56QWdNSGdLQ2k4dklGUm9hWE1nVkVWQlRDQjNZWE1nWjJWdVpYSmhkR1ZrSUdKNUlGUkZRVXhUWTNKcGNIUWdkakF1TVRBM0xqSUtMeThnYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5VVJVRk1VMk55YVhCMENnb3ZMeUJVYUdseklHTnZiblJ5WVdOMElHbHpJR052YlhCc2FXRnVkQ0IzYVhSb0lHRnVaQzl2Y2lCcGJYQnNaVzFsYm5SeklIUm9aU0JtYjJ4c2IzZHBibWNnUVZKRGN6b2dXeUJCVWtNMElGMEtDaTh2SUZSb1pTQm1iMnhzYjNkcGJtY2dkR1Z1SUd4cGJtVnpJRzltSUZSRlFVd2dhR0Z1Wkd4bElHbHVhWFJwWVd3Z2NISnZaM0poYlNCbWJHOTNDaTh2SUZSb2FYTWdjR0YwZEdWeWJpQnBjeUIxYzJWa0lIUnZJRzFoYTJVZ2FYUWdaV0Z6ZVNCbWIzSWdZVzU1YjI1bElIUnZJSEJoY25ObElIUm9aU0J6ZEdGeWRDQnZaaUIwYUdVZ2NISnZaM0poYlNCaGJtUWdaR1YwWlhKdGFXNWxJR2xtSUdFZ2MzQmxZMmxtYVdNZ1lXTjBhVzl1SUdseklHRnNiRzkzWldRS0x5OGdTR1Z5WlN3Z1lXTjBhVzl1SUhKbFptVnljeUIwYnlCMGFHVWdUMjVEYjIxd2JHVjBaU0JwYmlCamIyMWlhVzVoZEdsdmJpQjNhWFJvSUhkb1pYUm9aWElnZEdobElHRndjQ0JwY3lCaVpXbHVaeUJqY21WaGRHVmtJRzl5SUdOaGJHeGxaQW92THlCRmRtVnllU0J3YjNOemFXSnNaU0JoWTNScGIyNGdabTl5SUhSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nY21Wd2NtVnpaVzUwWldRZ2FXNGdkR2hsSUhOM2FYUmphQ0J6ZEdGMFpXMWxiblFLTHk4Z1NXWWdkR2hsSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaGxJR052Ym5SeVlXTjBMQ0JwZEhNZ2NtVnpjR1ZqZEdsMlpTQmljbUZ1WTJnZ2QybHNiQ0JpWlNBaUtrNVBWRjlKVFZCTVJVMUZUbFJGUkNJZ2QyaHBZMmdnYW5WemRDQmpiMjUwWVdsdWN5QWlaWEp5SWdwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvaENuQjFjMmhwYm5RZ05nb3FDblI0YmlCUGJrTnZiWEJzWlhScGIyNEtLd3B6ZDJsMFkyZ2dLbU5oYkd4ZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0ttTnlaV0YwWlY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkFvS0trNVBWRjlKVFZCTVJVMUZUbFJGUkRvS0NTOHZJRlJvWlNCeVpYRjFaWE4wWldRZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR2x6SUdOdmJuUnlZV04wTGlCQmNtVWdlVzkxSUhWemFXNW5JSFJvWlNCamIzSnlaV04wSUU5dVEyOXRjR3hsZEdVL0lFUnBaQ0I1YjNVZ2MyVjBJSGx2ZFhJZ1lYQndJRWxFUHdvSlpYSnlDZ292THlCMWNHUmhkR1ZUZEdGMGFXTkdhV1ZzWkVsdVJIbHVZVzFwWTA5aWFtVmpkRWx1UW05NEtDbHpkSEpwYm1jS0ttRmlhVjl5YjNWMFpWOTFjR1JoZEdWVGRHRjBhV05HYVdWc1pFbHVSSGx1WVcxcFkwOWlhbVZqZEVsdVFtOTRPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdkWEJrWVhSbFUzUmhkR2xqUm1sbGJHUkpia1I1Ym1GdGFXTlBZbXBsWTNSSmJrSnZlQ2dwYzNSeWFXNW5DZ2xqWVd4c2MzVmlJSFZ3WkdGMFpWTjBZWFJwWTBacFpXeGtTVzVFZVc1aGJXbGpUMkpxWldOMFNXNUNiM2dLQ1dSMWNBb0piR1Z1Q2dscGRHOWlDZ2xsZUhSeVlXTjBJRFlnTWdvSmMzZGhjQW9KWTI5dVkyRjBDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnZFhCa1lYUmxVM1JoZEdsalJtbGxiR1JKYmtSNWJtRnRhV05QWW1wbFkzUkpia0p2ZUNncE9pQnpkSEpwYm1jS2RYQmtZWFJsVTNSaGRHbGpSbWxsYkdSSmJrUjVibUZ0YVdOUFltcGxZM1JKYmtKdmVEb0tDWEJ5YjNSdklEQWdNUW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6b3hOVGN6Q2drdkx5QjBhR2x6TG1KTllYQW9KMkpOWVhBbktTNTJZV3gxWlNBOUlIc2dZV1JrY2pvZ2RHaHBjeTUwZUc0dWMyVnVaR1Z5TENCemRISTZJQ2RJWld4c2J5QlhiM0pzWkNFbklIMEtDV0o1ZEdWaklEQWdMeThnTUhnd01EQTBOakkwWkRZeE56QUtDV1IxY0FvSlltOTRYMlJsYkFvSmNHOXdDZ2xpZVhSbFl5QXhJQzh2SUNCcGJtbDBhV0ZzSUdobFlXUUtDV0o1ZEdWaklERWdMeThnSUdsdWFYUnBZV3dnZEdGcGJBb0pjSFZ6YUdKNWRHVnpJREI0TURBeU1pQXZMeUJwYm1sMGFXRnNJR2hsWVdRZ2IyWm1jMlYwQ2dsMGVHNGdVMlZ1WkdWeUNnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgzTjBZWFJwWTE5MGRYQnNaVjlsYkdWdFpXNTBDZ2x3ZFhOb1lubDBaWE1nTUhnd01EQmpORGcyTlRaak5tTTJaakl3TlRjMlpqY3lObU0yTkRJeENnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KY0c5d0lDOHZJSEJ2Y0NCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMElDOHZJR052Ym1OaGRDQm9aV0ZrSUdGdVpDQjBZV2xzQ2dsaWIzaGZjSFYwQ2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwyRmlhUzVoYkdkdkxuUnpPakUxTnpVS0NTOHZJSFJvYVhNdVlrMWhjQ2duWWsxaGNDY3BMblpoYkhWbExtRmtaSElnUFNCMGFHbHpMblI0Ymk1elpXNWtaWElLQ1dKNWRHVmpJREFnTHk4Z01IZ3dNREEwTmpJMFpEWXhOekFLQ1dKdmVGOW5aWFFLQ2drdkx5QmliM2dnZG1Gc2RXVWdaRzlsY3lCdWIzUWdaWGhwYzNRNklIUm9hWE11WWsxaGNDZ25ZazFoY0NjcExuWmhiSFZsQ2dsaGMzTmxjblFLQ1hOMGIzSmxJREkxTlNBdkx5Qm1kV3hzSUdGeWNtRjVDZ2xzYjJGa0lESTFOU0F2THlCbWRXeHNJR0Z5Y21GNUNnbHdkWE5vYVc1MElEQUtDWFI0YmlCVFpXNWtaWElLQ1hKbGNHeGhZMlV6Q2dsaWVYUmxZeUF3SUM4dklEQjRNREF3TkRZeU5HUTJNVGN3Q2dsa2RYQUtDV0p2ZUY5a1pXd0tDWEJ2Y0FvSmMzZGhjQW9KWW05NFgzQjFkQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6b3hOVGMyQ2drdkx5QnlaWFIxY200Z2RHaHBjeTVpVFdGd0tDZGlUV0Z3SnlrdWRtRnNkV1V1YzNSeU93b0pZbmwwWldNZ01DQXZMeUF3ZURBd01EUTJNalJrTmpFM01Bb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NWlUV0Z3S0NkaVRXRndKeWt1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pjM1J2Y21VZ01qVTFJQzh2SUdaMWJHd2dZWEp5WVhrS0NYQjFjMmhwYm5RZ016SUtDV3h2WVdRZ01qVTFJQzh2SUdaMWJHd2dZWEp5WVhrS0NXeHZZV1FnTWpVMUlDOHZJR1oxYkd3Z1lYSnlZWGtLQ1hWdVkyOTJaWElnTWdvSlpYaDBjbUZqZEY5MWFXNTBNVFlLQ1dSMWNDQXZMeUJrZFhCc2FXTmhkR1VnYzNSaGNuUWdiMllnWld4bGJXVnVkQW9KYkc5aFpDQXlOVFVnTHk4Z1puVnNiQ0JoY25KaGVRb0pjM2RoY0FvSlpYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z1oyVjBJRzUxYldKbGNpQnZaaUJsYkdWdFpXNTBjd29KYVc1MFl5QXdJQzh2SUNCblpYUWdkSGx3WlNCc1pXNW5kR2dLQ1NvZ0x5OGdiWFZzZEdsd2JIa2dZbmtnZEhsd1pTQnNaVzVuZEdnS0NYQjFjMmhwYm5RZ01nb0pLeUF2THlCaFpHUWdkSGR2SUdadmNpQnNaVzVuZEdnS0NXVjRkSEpoWTNRekNnbGxlSFJ5WVdOMElESWdNQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURFM056UTBNekpsSUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsVTNSaGRHbGpSbWxsYkdSSmJrUjVibUZ0YVdOUFltcGxZM1JKYmtKdmVDZ3BjM1J5YVc1bklnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5MWNHUmhkR1ZUZEdGMGFXTkdhV1ZzWkVsdVJIbHVZVzFwWTA5aWFtVmpkRWx1UW05NENnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTmhiR3dnVG05UGNBb0paWEp5Q2dvcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWREb0tDWEJ5YjNSdklEUWdNd29KWm5KaGJXVmZaR2xuSUMwMElDOHZJSFIxY0d4bElHaGxZV1FLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJsYkdWdFpXNTBDZ2xqYjI1allYUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1hKbGRITjFZZ29LS25CeWIyTmxjM05mWkhsdVlXMXBZMTkwZFhCc1pWOWxiR1Z0Wlc1ME9nb0pjSEp2ZEc4Z05DQXpDZ2xtY21GdFpWOWthV2NnTFRRZ0x5OGdkSFZ3YkdVZ2FHVmhaQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJR2hsWVdRZ2IyWm1jMlYwQ2dsamIyNWpZWFFLQ1daeVlXMWxYMkoxY25rZ0xUUWdMeThnZEhWd2JHVWdhR1ZoWkFvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdWc1pXMWxiblFLQ1dSMWNBb0piR1Z1Q2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYUdWaFpDQnZabVp6WlhRS0NXSjBiMmtLQ1NzS0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbG1jbUZ0WlY5aWRYSjVJQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2xtY21GdFpWOWthV2NnTFRNZ0x5OGdkSFZ3YkdVZ2RHRnBiQW9KYzNkaGNBb0pZMjl1WTJGMENnbG1jbUZ0WlY5aWRYSjVJQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRNZ0x5OGdkSFZ3YkdVZ2RHRnBiQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJR2hsWVdRZ2IyWm1jMlYwQ2dseVpYUnpkV0k9IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVNZQ0JnQUVZazFoY0FBeEdCU0JCZ3N4R1FpTkRBQjlBQUFBQUFBQUFBQUFBQUJ2QUFBQUFBQUFBQUFBQUFDQUJCVWZmSFdJQUF4SkZSWlhCZ0pNVUZDd0lrT0tBQUVvU2J4SUtTbUFBZ0FpTVFDSUFHT0FEZ0FNU0dWc2JHOGdWMjl5YkdRaGlBQmRTRkMvS0w1RU5mODAvNEVBTVFCZEtFbThTRXkvS0w1RU5mK0JJRFQvTlA5UEFsbEpOUDlNV1NJTGdRSUlXRmNDQUlraVE0QUV1RVI3TmpZYUFJNEIvL0VBZ0FRWGRFTXVOaG9BamdIL2R3Q0tCQU9ML0l2L1VJdjlpLzZKaWdRRGkveUwvbENNL0l2L1NSV0wvaGNJRmxjR0FveitpLzFNVUl6OWkveUwvWXYraVE9PSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
