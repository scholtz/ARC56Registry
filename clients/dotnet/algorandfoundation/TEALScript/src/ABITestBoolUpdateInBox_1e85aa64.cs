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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestBoolUpdateInBox_1e85aa64
{


    public class ABITestBoolUpdateInBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestBoolUpdateInBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Data : AVMObjectType
            {
                public ulong Value { get; set; }

                public bool Bool { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vValue.From(Value);
                    ret.AddRange(vValue.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBool.From(Bool);
                    ret.AddRange(vBool.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Data Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Data();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is ulong vValueValue) { ret.Value = vValueValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBool = vBool.ToValue();
                    if (valueBool is bool vBoolValue) { ret.Bool = vBoolValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Data);
                }
                public bool Equals(Data? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Data left, Data right)
                {
                    return EqualityComparer<Data>.Default.Equals(left, right);
                }
                public static bool operator !=(Data left, Data right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task BoolUpdateInBox(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 11, 31, 2 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BoolUpdateInBox_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 11, 31, 2 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0Qm9vbFVwZGF0ZUluQm94IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJEYXRhIjpbeyJuYW1lIjoidmFsdWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYm9vbCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb2xVcGRhdGVJbkJveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjAifSx7InBjIjpbMSwyLDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzQsNSw2LDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzgsOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzEwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjAifSx7InBjIjpbMTEsMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMCJ9LHsicGMiOlsxM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzE0LDE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjAifSx7InBjIjpbMTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMCJ9LHsicGMiOlsxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOSw0MCw0MSw0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzQzXSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzQ0LDQ1LDQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjMifSx7InBjIjpbNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMyJ9LHsicGMiOls0OCw0OSw1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIzIn0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjMifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMyJ9LHsicGMiOls1Myw1NCw1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIzIn0seyJwYyI6WzU2LDU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjMifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNCJ9LHsicGMiOls1OSw2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI0In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjQifSx7InBjIjpbNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNCJ9LHsicGMiOls2Myw2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI0In0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjUifSx7InBjIjpbNjYsNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNSJ9LHsicGMiOls2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI1In0seyJwYyI6WzY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjUifSx7InBjIjpbNzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNSJ9LHsicGMiOls3MV0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhpZCkudmFsdWUiLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjUifSx7InBjIjpbNzIsNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNSJ9LHsicGMiOls3NCw3NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI1In0seyJwYyI6Wzc2LDc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjUifSx7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNSJ9LHsicGMiOls3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI1In0seyJwYyI6WzgwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjUifSx7InBjIjpbODEsODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNSJ9LHsicGMiOls4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI1In0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjUifSx7InBjIjpbODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyNSJ9LHsicGMiOls4Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzI1In0seyJwYyI6Wzg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjMifSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMCJ9LHsicGMiOls4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzkwLDkxLDkyLDkzLDk0LDk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjAifSx7InBjIjpbOTYsOTcsOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMCJ9LHsicGMiOls5OSwxMDAsMTAxLDEwMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMCJ9LHsicGMiOlsxMDQsMTA1LDEwNiwxMDcsMTA4LDEwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzIwIn0seyJwYyI6WzExMCwxMTEsMTEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjAifSx7InBjIjpbMTEzLDExNCwxMTUsMTE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MjAifSx7InBjIjpbMTE3XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjk0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcyMCJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDbUo1ZEdWallteHZZMnNnTUhnMk1Rb0tMeThnVkdocGN5QlVSVUZNSUhkaGN5Qm5aVzVsY21GMFpXUWdZbmtnVkVWQlRGTmpjbWx3ZENCMk1DNHhNRFl1TVFvdkx5Qm9kSFJ3Y3pvdkwyZHBkR2gxWWk1amIyMHZZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMVJGUVV4VFkzSnBjSFFLQ2k4dklGUm9hWE1nWTI5dWRISmhZM1FnYVhNZ1kyOXRjR3hwWVc1MElIZHBkR2dnWVc1a0wyOXlJR2x0Y0d4bGJXVnVkSE1nZEdobElHWnZiR3h2ZDJsdVp5QkJVa056T2lCYklFRlNRelFnWFFvS0x5OGdWR2hsSUdadmJHeHZkMmx1WnlCMFpXNGdiR2x1WlhNZ2IyWWdWRVZCVENCb1lXNWtiR1VnYVc1cGRHbGhiQ0J3Y205bmNtRnRJR1pzYjNjS0x5OGdWR2hwY3lCd1lYUjBaWEp1SUdseklIVnpaV1FnZEc4Z2JXRnJaU0JwZENCbFlYTjVJR1p2Y2lCaGJubHZibVVnZEc4Z2NHRnljMlVnZEdobElITjBZWEowSUc5bUlIUm9aU0J3Y205bmNtRnRJR0Z1WkNCa1pYUmxjbTFwYm1VZ2FXWWdZU0J6Y0dWamFXWnBZeUJoWTNScGIyNGdhWE1nWVd4c2IzZGxaQW92THlCSVpYSmxMQ0JoWTNScGIyNGdjbVZtWlhKeklIUnZJSFJvWlNCUGJrTnZiWEJzWlhSbElHbHVJR052YldKcGJtRjBhVzl1SUhkcGRHZ2dkMmhsZEdobGNpQjBhR1VnWVhCd0lHbHpJR0psYVc1bklHTnlaV0YwWldRZ2IzSWdZMkZzYkdWa0NpOHZJRVYyWlhKNUlIQnZjM05wWW14bElHRmpkR2x2YmlCbWIzSWdkR2hwY3lCamIyNTBjbUZqZENCcGN5QnlaWEJ5WlhObGJuUmxaQ0JwYmlCMGFHVWdjM2RwZEdOb0lITjBZWFJsYldWdWRBb3ZMeUJKWmlCMGFHVWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdVZ1kyOXVkSEpoWTNRc0lHbDBjeUJ5WlhOd1pXTjBhWFpsSUdKeVlXNWphQ0IzYVd4c0lHSmxJQ0lxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJaUIzYUdsamFDQnFkWE4wSUdOdmJuUmhhVzV6SUNKbGNuSWlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUVLY0hWemFHbHVkQ0EyQ2lvS2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvckNuTjNhWFJqYUNBcVkyRnNiRjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxWTNKbFlYUmxYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVDZ29xVGs5VVgwbE5VRXhGVFVWT1ZFVkVPZ29KTHk4Z1ZHaGxJSEpsY1hWbGMzUmxaQ0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb2FYTWdZMjl1ZEhKaFkzUXVJRUZ5WlNCNWIzVWdkWE5wYm1jZ2RHaGxJR052Y25KbFkzUWdUMjVEYjIxd2JHVjBaVDhnUkdsa0lIbHZkU0J6WlhRZ2VXOTFjaUJoY0hBZ1NVUS9DZ2xsY25JS0NpOHZJR0p2YjJ4VmNHUmhkR1ZKYmtKdmVDaDFhVzUwTmpRcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJKdmIyeFZjR1JoZEdWSmJrSnZlRG9LQ1M4dklHbGtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHSnZiMnhWY0dSaGRHVkpia0p2ZUNoMWFXNTBOalFwZG05cFpBb0pZMkZzYkhOMVlpQmliMjlzVlhCa1lYUmxTVzVDYjNnS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdKdmIyeFZjR1JoZEdWSmJrSnZlQ2hwWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQXBpYjI5c1ZYQmtZWFJsU1c1Q2IzZzZDZ2x3Y205MGJ5QXhJREFLQ2drdkx5QlFkWE5vSUdWdGNIUjVJR0o1ZEdWeklHRm1kR1Z5SUhSb1pTQm1jbUZ0WlNCd2IybHVkR1Z5SUhSdklISmxjMlZ5ZG1VZ2MzQmhZMlVnWm05eUlHeHZZMkZzSUhaaGNtbGhZbXhsY3dvSmNIVnphR0o1ZEdWeklEQjRDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJGaWFTNWhiR2R2TG5Sek9qRTNNalFLQ1M4dklHSnZlQ0E5SUhSb2FYTXVZbTk0WlhNb2FXUXBMblpoYkhWbENnbGllWFJsWXlBd0lDOHZJQ0FpWVNJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCcFpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1daeVlXMWxYMkoxY25rZ01DQXZMeUJ6ZEc5eVlXZGxJR3RsZVM4dlltOTRDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJGaWFTNWhiR2R2TG5Sek9qRTNNalVLQ1M4dklIUm9hWE11WW05NFpYTW9hV1FwTG5aaGJIVmxMbUp2YjJ3Z1BTQjBjblZsQ2dsaWVYUmxZeUF3SUM4dklDQWlZU0lLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJwWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV0p2ZUY5blpYUUtDZ2t2THlCaWIzZ2dkbUZzZFdVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1E2SUhSb2FYTXVZbTk0WlhNb2FXUXBMblpoYkhWbENnbGhjM05sY25RS0NYTjBiM0psSURJMU5TQXZMeUJtZFd4c0lHRnljbUY1Q2dsc2IyRmtJREkxTlNBdkx5Qm1kV3hzSUdGeWNtRjVDZ2x3ZFhOb2FXNTBJRFkwQ2dscGJuUmpJREFnTHk4Z01Rb0pjMlYwWW1sMENnbGllWFJsWXlBd0lDOHZJQ0FpWVNJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCcFpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1hOM1lYQUtDV0p2ZUY5d2RYUUtDWEpsZEhOMVlnb0tLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpcGpjbVZoZEdWZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOeVpXRjBaU0JPYjA5d0NnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGcwWkRCaU1XWXdNaUF2THlCdFpYUm9iMlFnSW1KdmIyeFZjR1JoZEdWSmJrSnZlQ2gxYVc1ME5qUXBkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWW05dmJGVndaR0YwWlVsdVFtOTRDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFTWUJBV0V4R0JTQkJnc3hHUWlOREFBOUFBQUFBQUFBQUFBQUFBQXZBQUFBQUFBQUFBQUFBQUEyR2dFWGlBQUNJa09LQVFDQUFDaUwveFpRakFBb2kvOFdVTDVFTmY4MC80RkFJbFFvaS84V1VFeS9pU0pEZ0FTNFJIczJOaG9BamdILzhRQ0FCRTBMSHdJMkdnQ09BZiszQUE9PSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjAsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiNjNkMjcxY2YifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
