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

namespace Arc56.Generated.algorandfoundation.puya_ts.Hello_fb01ccfd
{


    public class HelloProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HelloProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Greeting : AVMObjectType
            {
                public string Name { get; set; }

                public string Termination { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTermination = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTermination.From(Termination);
                    stringRef[ret.Count] = vTermination.Encode();
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

                public static Greeting Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Greeting();
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexTermination = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTermination = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTermination.Decode(bytes.Skip(indexTermination + prefixOffset).ToArray());
                    var valueTermination = vTermination.ToValue();
                    if (valueTermination is string vTerminationValue) { ret.Termination = vTerminationValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Greeting);
                }
                public bool Equals(Greeting? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Greeting left, Greeting right)
                {
                    return EqualityComparer<Greeting>.Default.Equals(left, right);
                }
                public static bool operator !=(Greeting left, Greeting right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="greeting"> </param>
        public async Task HelloCreate(string greeting, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 146, 37, 174 };
            var greetingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); greetingAbi.From(greeting);

            var result = await base.CallApp(new List<object> { abiHandle, greetingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> HelloCreate_Transactions(string greeting, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 146, 37, 174 };
            var greetingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); greetingAbi.From(greeting);

            return await base.MakeTransactionList(new List<object> { abiHandle, greetingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Greet(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 162, 130, 0 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Greet_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 162, 130, 0 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> Greeting</param>
        public async Task<string> SendGreetings(Structs.Greeting a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 128, 186, 32 };

            var result = await base.CallApp(new List<object> { abiHandle, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SendGreetings_Transactions(Structs.Greeting a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 128, 186, 32 };

            return await base.MakeTransactionList(new List<object> { abiHandle, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVsbG8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR3JlZXRpbmciOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRlcm1pbmF0aW9uIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJoZWxsb0NyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncmVldGluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3JlZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNlbmRHcmVldGluZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiR3JlZXRpbmciLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzc4LDM5OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NywyMzksMjk2LDMyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNiwyNDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9wcmVjb21waWxlZC1hcHBzLmFsZ28udHM6OkdyZWV0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1dGY4W10pLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MywzMDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVozSmxaWFJwYm1jaUlDSWlJREI0TVRVeFpqZGpOelVnSWlBaUNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lpQnRZV2x1WDJsbVgySnZaSGxBTVFvS2JXRnBibDlwWmw5aWIyUjVRREU2Q2lBZ0lDQmpZV3hzYzNWaUlHTnZibk4wY25WamRHOXlDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBekNncHRZV2x1WDJKc2IyTnJRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nU0dWc2JHOGdaWGgwWlc1a2N5QklaV3hzYjBKaGMyVWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNalF6Tnpoa00yTWdMeThnYldWMGFHOWtJQ0prWld4bGRHVW9LWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaE1HVTRNVGczTWlBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlNncGRtOXBaQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYldGMFkyZ2diV0ZwYmw5a1pXeGxkR1ZmY205MWRHVkFOQ0J0WVdsdVgzVndaR0YwWlY5eWIzVjBaVUExQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMkNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSVpXeHNieUJsZUhSbGJtUnpJRWhsYkd4dlFtRnpaU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Rb2dJQ0FnWWlCdFlXbHVYMk5oYkd4ZlRtOVBjRUEzQ2dwdFlXbHVYMk5oYkd4ZlRtOVBjRUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVobGJHeHZJR1Y0ZEdWdVpITWdTR1ZzYkc5Q1lYTmxJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1F3WVRJNE1qQXdJQzh2SUcxbGRHaHZaQ0FpWjNKbFpYUW9jM1J5YVc1bktYTjBjbWx1WnlJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVeE9EQmlZVEl3SUM4dklHMWxkR2h2WkNBaWMyVnVaRWR5WldWMGFXNW5jeWdvYzNSeWFXNW5MSE4wY21sdVp5a3BjM1J5YVc1bklnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmR5WldWMFgzSnZkWFJsUURnZ2JXRnBibDl6Wlc1a1IzSmxaWFJwYm1kelgzSnZkWFJsUURrS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXdDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UQTZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFaGxiR3h2SUdWNGRHVnVaSE1nU0dWc2JHOUNZWE5sSUhzS0lDQWdJR1Z5Y2dvS2JXRnBibDl6Wlc1a1IzSmxaWFJwYm1kelgzSnZkWFJsUURrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJ6Wlc1a1IzSmxaWFJwYm1kektHRTZJRWR5WldWMGFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2MyVnVaRWR5WldWMGFXNW5jd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRBS0NtMWhhVzVmWjNKbFpYUmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdkeVpXVjBLRzVoYldVNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR2R5WldWMENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSVpXeHNieUJsZUhSbGJtUnpJRWhsYkd4dlFtRnpaU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURreU1qVmhaU0F2THlCdFpYUm9iMlFnSW1obGJHeHZRM0psWVhSbEtITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0J0WVhSamFDQnRZV2x1WDJobGJHeHZRM0psWVhSbFgzSnZkWFJsUURFeUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNd29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXpPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ20xaGFXNWZhR1ZzYkc5RGNtVmhkR1ZmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dKMmhsYkd4dlEzSmxZWFJsSnl3Z2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1VLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFekNncHRZV2x1WDNWd1pHRjBaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0oxVndaR0YwWlVGd2NHeHBZMkYwYVc5dUp5QjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eklDOHZJRlZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFlLQ20xaGFXNWZaR1ZzWlhSbFgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJR1JsYkdWMFpRb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2tobGJHeHZMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUdJZ1kzSmxZWFJsWDJKc2IyTnJRREFLQ21OeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzVoYldVNklDZG9aV3hzYjBOeVpXRjBaU2NzSUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcElaV3hzYnk1amNtVmhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwSVpXeHNiMEpoYzJVdVpHVnNaWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsT2dvZ0lDQWdZaUJrWld4bGRHVmZZbXh2WTJ0QU1Bb0taR1ZzWlhSbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRuSUgwcENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9raGxiR3h2UW1GelpTNWtaV3hsZEdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcElaV3hzYjBKaGMyVXVkWEJrWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbE9nb2dJQ0FnWWlCMWNHUmhkR1ZmWW14dlkydEFNQW9LZFhCa1lYUmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0bklIMHBDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPa2hsYkd4dlFtRnpaUzUxY0dSaGRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBJWld4c2IwSmhjMlV1WjNKbFpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuY21WbGREb0tJQ0FnSUdJZ1ozSmxaWFJmWW14dlkydEFNQW9LWjNKbFpYUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdkeVpXVjBLRzVoYldVNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlNHVnNiRzlDWVhObExtZHlaV1YwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwSVpXeHNiMEpoYzJVdWMyVnVaRWR5WldWMGFXNW5jMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGJtUkhjbVZsZEdsdVozTTZDaUFnSUNCaUlITmxibVJIY21WbGRHbHVaM05mWW14dlkydEFNQW9LYzJWdVpFZHlaV1YwYVc1bmMxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnYzJWdVpFZHlaV1YwYVc1bmN5aGhPaUJIY21WbGRHbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFkR1k0VzEwcExDaHNaVzRyZFhSbU9GdGRLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F4SUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcEhjbVZsZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcElaV3hzYjBKaGMyVXVjMlZ1WkVkeVpXVjBhVzVuY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlNHVnNiRzh1WTNKbFlYUmxLR2R5WldWMGFXNW5PaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlNHVnNiRzh1WTNKbFlYUmxPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvek5pMHpOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc1aGJXVTZJQ2RvWld4c2IwTnlaV0YwWlNjc0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lDOHZJR055WldGMFpTaG5jbVZsZEdsdVp6b2djM1J5YVc1bktTQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZTR1ZzYkc4dVkzSmxZWFJsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPa2hsYkd4dkxtTnlaV0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdaM0psWlhScGJtY2dQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nSnljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHlaV1YwYVc1bklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnZEdocGN5NW5jbVZsZEdsdVp5NTJZV3gxWlNBOUlHZHlaV1YwYVc1bkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBJWld4c2IwSmhjMlV1WkdWc1pYUmxLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZTR1ZzYkc5Q1lYTmxMbVJsYkdWMFpUb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82U0dWc2JHOUNZWE5sTG1SbGJHVjBaVjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcElaV3hzYjBKaGMyVXVaR1ZzWlhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBJWld4c2IwSmhjMlV1ZFhCa1lYUmxLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZTR1ZzYkc5Q1lYTmxMblZ3WkdGMFpUb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82U0dWc2JHOUNZWE5sTG5Wd1pHRjBaVjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcElaV3hzYjBKaGMyVXVkWEJrWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBJWld4c2IwSmhjMlV1WjNKbFpYUW9ibUZ0WlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBJWld4c2IwSmhjMlV1WjNKbFpYUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCbmNtVmxkQ2h1WVcxbE9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9raGxiR3h2UW1GelpTNW5jbVZsZEY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBJWld4c2IwSmhjMlV1WjNKbFpYUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUhKbGRIVnliaUJnSkh0MGFHbHpMbWR5WldWMGFXNW5MblpoYkhWbGZTQWtlMjVoYldWOVlBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR2R5WldWMGFXNW5JRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUNjbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5jbVZsZEdsdVp5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUhKbGRIVnliaUJnSkh0MGFHbHpMbWR5WldWMGFXNW5MblpoYkhWbGZTQWtlMjVoYldWOVlBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6RWdMeThnSWlJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0lnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82U0dWc2JHOUNZWE5sTG5ObGJtUkhjbVZsZEdsdVozTW9ZVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcElaV3hzYjBKaGMyVXVjMlZ1WkVkeVpXVjBhVzVuY3pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJSE5sYm1SSGNtVmxkR2x1WjNNb1lUb2dSM0psWlhScGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPa2hsYkd4dlFtRnpaUzV6Wlc1a1IzSmxaWFJwYm1kelgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2tobGJHeHZRbUZ6WlM1elpXNWtSM0psWlhScGJtZHpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCeVpYUjFjbTRnWUNSN2RHaHBjeTVuY21WbGRHbHVaeTUyWVd4MVpYMGdKSHRoTG01aGJXVjlKSHRoTG5SbGNtMXBibUYwYVc5dUxtNWhkR2wyWlgxZ0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdaM0psWlhScGJtY2dQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nSnljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHlaV1YwYVc1bklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY21WMGRYSnVJR0FrZTNSb2FYTXVaM0psWlhScGJtY3VkbUZzZFdWOUlDUjdZUzV1WVcxbGZTUjdZUzUwWlhKdGFXNWhkR2x2Ymk1dVlYUnBkbVY5WUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJaUlLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82U0dWc2JHOUNZWE5sTG1OdmJuTjBjblZqZEc5eUtDa2dMVDRnZG05cFpEb0tZMjl1YzNSeWRXTjBiM0k2Q2lBZ0lDQmlJR052Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREFLQ21OdmJuTjBjblZqZEc5eVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJoWW5OMGNtRmpkQ0JqYkdGemN5QklaV3hzYjBKaGMyVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCaUlHTnZibk4wY25WamRHOXlYMkpzYjJOclFERUtDbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmhZbk4wY21GamRDQmpiR0Z6Y3lCSVpXeHNiMEpoYzJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JpSUdOdmJuTjBjblZqZEc5eVgyRm1kR1Z5WDJsdWJHbHVaV1JmUUdGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5aGJHZHZjbUZ1WkMxMGVYQmxjMk55YVhCMEwySmhjMlV0WTI5dWRISmhZM1F1WkM1MGN6bzZRbUZ6WlVOdmJuUnlZV04wTG1OdmJuTjBjblZqZEc5eVFESUtDbU52Ym5OMGNuVmpkRzl5WDJGbWRHVnlYMmx1YkdsdVpXUmZRR0ZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTloYkdkdmNtRnVaQzEwZVhCbGMyTnlhWEIwTDJKaGMyVXRZMjl1ZEhKaFkzUXVaQzUwY3pvNlFtRnpaVU52Ym5SeVlXTjBMbU52Ym5OMGNuVmpkRzl5UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJuY21WbGRHbHVaeUE5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lBbkp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaM0psWlhScGJtY2lDaUFnSUNCaWVYUmxZMTh4SUM4dklDSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNCQ1lFQ0dkeVpXVjBhVzVuQUFRVkgzeDFBU0JDQUFBeEdFQUFDVUlBQUlnQmswSUFBRUlBQURZYUFJQUVKRGVOUElBRW9PZ1ljazhDamdJQVp3QlhRZ0FBTVJraUVrUXhHQ0lUUVFBdFFnQUFOaG9BZ0FUUW9vSUFnQVJSZ0xvZ1R3S09BZ0FOQUFkQ0FBQkNBQUFBaUFDWFF2LzJpQUJwUXYvd05ob0FnQVFBa2lXdVR3R09BUUFHUWdBQVF2L2VpQUFrUXYvM01Sa2xFakVZSWhNUVJJZ0FOa0wvbkRFWmdRVVNNUmdpRXhCRWlBQWRRditMUWdBQU5ob0JTU0paSXdza0NFc0JGUkpFVndJQWlBQ0pJME5DQUFDSUFJd2pRMElBQUlnQWlDTkRRZ0FBTmhvQlNTSlpJd3NrQ0VzQkZSSkVWd0lBaUFCeVNSVVdWd1lDVHdGUUtrOEJVTEFqUTBJQUFEWWFBVWtWVGdGSklsbEpKUkpFU3dGUEFVc0RVaUpaSXdza0NDVUlTd0VrV1VsTEFoSkVTd0pQQVU4RVVpSlpJd3NrQ0FoTEFSVVNSSWdBTjBrVkZsY0dBazhCVUNwUEFWQ3dJME9LQVFCQ0FBQW9pLzluaVVJQUFJbENBQUNKaWdFQlFnQUFJaWhsUkNsUEFWQXJVSXYvVUltS0FRRkNBQUFpS0dWRUtVOEJVQ3RRaS84aVdZdi9KRm1MLzA4Q1R3SlNWd0lBVUl2L0pGbUwveFdMLzA4Q1R3SlNWd0lBVUlsQ0FBQkNBQUJDQUFBb0tXZUoiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
