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

namespace Arc56.Generated.IrfanChairurrachman.RantaiAdil.RantaiAdil_c197d60f
{


    public class RantaiAdilProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RantaiAdilProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Contributor : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong SharePercentage { get; set; }

                public bool Paid { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSharePercentage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSharePercentage.From(SharePercentage);
                    ret.AddRange(vSharePercentage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPaid.From(Paid);
                    ret.AddRange(vPaid.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Contributor Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Contributor();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSharePercentage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSharePercentage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSharePercentage = vSharePercentage.ToValue();
                    if (valueSharePercentage is ulong vSharePercentageValue) { ret.SharePercentage = vSharePercentageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaid = vPaid.ToValue();
                    if (valuePaid is bool vPaidValue) { ret.Paid = vPaidValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Contributor);
                }
                public bool Equals(Contributor? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Contributor left, Contributor right)
                {
                    return EqualityComparer<Contributor>.Default.Equals(left, right);
                }
                public static bool operator !=(Contributor left, Contributor right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Initialize the project with manager and client addresses.
        ///Can only be called once.
        ///</summary>
        /// <param name="manager">Address of the project manager </param>
        /// <param name="client">Address of the client who will pay </param>
        public async Task<string> SetupProject(Algorand.Address manager, Algorand.Address client, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 222, 57, 180 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);
            var clientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); clientAbi.From(client);

            var result = await base.CallApp(new List<object> { abiHandle, managerAbi, clientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetupProject_Transactions(Algorand.Address manager, Algorand.Address client, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 222, 57, 180 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);
            var clientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); clientAbi.From(client);

            return await base.MakeTransactionList(new List<object> { abiHandle, managerAbi, clientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a contributor with their share percentage.
        ///Only manager can call this before locking.
        ///</summary>
        /// <param name="contributor_address">Address of the contributor </param>
        /// <param name="share_percentage">Their share (0-100) </param>
        public async Task<string> AddContributor(Algorand.Address contributor_address, ulong share_percentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 22, 179, 2 };
            var contributor_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contributor_addressAbi.From(contributor_address);
            var share_percentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_percentageAbi.From(share_percentage);

            var result = await base.CallApp(new List<object> { abiHandle, contributor_addressAbi, share_percentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddContributor_Transactions(Algorand.Address contributor_address, ulong share_percentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 22, 179, 2 };
            var contributor_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contributor_addressAbi.From(contributor_address);
            var share_percentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_percentageAbi.From(share_percentage);

            return await base.MakeTransactionList(new List<object> { abiHandle, contributor_addressAbi, share_percentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Lock the contributors list to prevent modifications.
        ///Only manager can call this. Validates that total shares equal 100%.
        ///</summary>
        public async Task<string> LockContributors(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 49, 27, 236 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> LockContributors_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 49, 27, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Client funds the project by sending payment to contract.
        ///Can only be called after contributors are locked.
        ///</summary>
        /// <param name="payment">Payment transaction from client </param>
        public async Task<string> FundProject(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 18, 125, 202, 163 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> FundProject_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 18, 125, 202, 163 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark project as complete and distribute funds to all contributors.
        ///Only manager or client can call this.
        ///</summary>
        public async Task<string> CompleteAndPayout(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 106, 114, 159 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CompleteAndPayout_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 106, 114, 159 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current project status.
        ///</summary>
        public async Task<string> GetProjectStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 178, 102, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetProjectStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 178, 102, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the number of contributors.
        ///</summary>
        public async Task<ulong> GetContributorCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 199, 107, 104 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetContributorCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 199, 107, 104 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmFudGFpQWRpbCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDb250cmlidXRvciI6W3sibmFtZSI6ImFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNoYXJlX3BlcmNlbnRhZ2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGFpZCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXR1cF9wcm9qZWN0IiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHByb2plY3Qgd2l0aCBtYW5hZ2VyIGFuZCBjbGllbnQgYWRkcmVzc2VzLlxuQ2FuIG9ubHkgYmUgY2FsbGVkIG9uY2UuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYW5hZ2VyIiwiZGVzYyI6IkFkZHJlc3Mgb2YgdGhlIHByb2plY3QgbWFuYWdlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsaWVudCIsImRlc2MiOiJBZGRyZXNzIG9mIHRoZSBjbGllbnQgd2hvIHdpbGwgcGF5IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MgbWVzc2FnZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9jb250cmlidXRvciIsImRlc2MiOiJBZGQgYSBjb250cmlidXRvciB3aXRoIHRoZWlyIHNoYXJlIHBlcmNlbnRhZ2UuXG5Pbmx5IG1hbmFnZXIgY2FuIGNhbGwgdGhpcyBiZWZvcmUgbG9ja2luZy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRyaWJ1dG9yX2FkZHJlc3MiLCJkZXNjIjoiQWRkcmVzcyBvZiB0aGUgY29udHJpYnV0b3IiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlX3BlcmNlbnRhZ2UiLCJkZXNjIjoiVGhlaXIgc2hhcmUgKDAtMTAwKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIG1lc3NhZ2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2NrX2NvbnRyaWJ1dG9ycyIsImRlc2MiOiJMb2NrIHRoZSBjb250cmlidXRvcnMgbGlzdCB0byBwcmV2ZW50IG1vZGlmaWNhdGlvbnMuXG5Pbmx5IG1hbmFnZXIgY2FuIGNhbGwgdGhpcy4gVmFsaWRhdGVzIHRoYXQgdG90YWwgc2hhcmVzIGVxdWFsIDEwMCUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MgbWVzc2FnZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ1bmRfcHJvamVjdCIsImRlc2MiOiJDbGllbnQgZnVuZHMgdGhlIHByb2plY3QgYnkgc2VuZGluZyBwYXltZW50IHRvIGNvbnRyYWN0LlxuQ2FuIG9ubHkgYmUgY2FsbGVkIGFmdGVyIGNvbnRyaWJ1dG9ycyBhcmUgbG9ja2VkLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6IlBheW1lbnQgdHJhbnNhY3Rpb24gZnJvbSBjbGllbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBtZXNzYWdlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29tcGxldGVfYW5kX3BheW91dCIsImRlc2MiOiJNYXJrIHByb2plY3QgYXMgY29tcGxldGUgYW5kIGRpc3RyaWJ1dGUgZnVuZHMgdG8gYWxsIGNvbnRyaWJ1dG9ycy5cbk9ubHkgbWFuYWdlciBvciBjbGllbnQgY2FuIGNhbGwgdGhpcy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBtZXNzYWdlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Byb2plY3Rfc3RhdHVzIiwiZGVzYyI6IkdldCBjdXJyZW50IHByb2plY3Qgc3RhdHVzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdGF0dXMgbWVzc2FnZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jb250cmlidXRvcl9jb3VudCIsImRlc2MiOiJHZXQgdGhlIG51bWJlciBvZiBjb250cmlidXRvcnMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6Ik51bWJlciBvZiBjb250cmlidXRvcnMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ1MV0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyXSwiZXJyb3JNZXNzYWdlIjoiQ29udHJpYnV0b3JzIGxpc3QgaXMgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc5XSwiZXJyb3JNZXNzYWdlIjoiQ29udHJpYnV0b3JzIG11c3QgYmUgbG9ja2VkIGZpcnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBwZXJjZW50YWdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAyXSwiZXJyb3JNZXNzYWdlIjoiTWluaW11bSBmdW5kaW5nIGlzIDEgQUxHTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2MF0sImVycm9yTWVzc2FnZSI6Ik5vIGNvbnRyaWJ1dG9ycyBhZGRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY2xpZW50IGNhbiBmdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBtYW5hZ2VyIGNhbiBhZGQgY29udHJpYnV0b3JzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBtYW5hZ2VyIGNhbiBsb2NrIGNvbnRyaWJ1dG9ycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3N10sImVycm9yTWVzc2FnZSI6Ik9ubHkgbWFuYWdlciBvciBjbGllbnQgY2FuIGNvbXBsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkzXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGdvIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg2LDY4OV0sImVycm9yTWVzc2FnZSI6IlByb2plY3QgYWxyZWFkeSBjb21wbGV0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzVdLCJlcnJvck1lc3NhZ2UiOiJQcm9qZWN0IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODJdLCJlcnJvck1lc3NhZ2UiOiJQcm9qZWN0IG5vdCBmdW5kZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3XSwiZXJyb3JNZXNzYWdlIjoiU2hhcmVzIG11c3Qgc3VtIHRvIDEwMCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzAsNjY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jbGllbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc3LDQ1OSw2OTYsMTAyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29udHJpYnV0b3JfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc4LDcyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29udHJpYnV0b3JzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NCw2ODcsOTQxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19jb21wbGV0ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUwLDQ0OSw1NzgsODQ2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19sb2NrZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcxLDM0Miw0NDEsNjU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYW5hZ2VyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNiw2ODEsNzMzLDkwMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZnVuZGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTksMjY3LDMyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01UQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnRZVzVoWjJWeUlpQWlkRzkwWVd4ZlpuVnVaR1ZrSWlBaWFYTmZiRzlqYTJWa0lpQWlZMjl1ZEhKcFluVjBiM0pmWTI5MWJuUWlJQ0pwYzE5amIyMXdiR1YwWldRaUlDSmpiR2xsYm5RaUlEQjRNVFV4Wmpkak56VWdJbU52Ym5SeWFXSjFkRzl5Y3lJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveU9Bb2dJQ0FnTHk4Z2MyVnNaaTV0WVc1aFoyVnlJRDBnUVdSa2NtVnpjeWdwSUNBaklGQnliMnBsWTNRZ2JXRnVZV2RsY2lCaFpHUnlaWE56Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVc1aFoyVnlJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakk1Q2lBZ0lDQXZMeUJ6Wld4bUxtTnNhV1Z1ZENBOUlFRmtaSEpsYzNNb0tTQWdJeUJEYkdsbGJuUWdkMmh2SUhkcGJHd2dablZ1WkNCMGFHVWdjSEp2YW1WamRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyeHBaVzUwSWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyWjFibVJsWkNBOUlGVkpiblEyTkNnd0tTQWdJeUJVYjNSaGJDQmhiVzkxYm5RZ1puVnVaR1ZrSUdKNUlHTnNhV1Z1ZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZablZ1WkdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJSE5sYkdZdWFYTmZiRzlqYTJWa0lEMGdSbUZzYzJVZ0lDTWdWMmhsZEdobGNpQmpiMjUwY21saWRYUnZjaUJzYVhOMElHbHpJR3h2WTJ0bFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWFYTmZiRzlqYTJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNeklLSUNBZ0lDOHZJSE5sYkdZdWFYTmZZMjl0Y0d4bGRHVmtJRDBnUm1Gc2MyVWdJQ01nVjJobGRHaGxjaUJ3Y205cVpXTjBJR2x6SUdOdmJYQnNaWFJsWkFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZlkyOXRjR3hsZEdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJSE5sYkdZdVkyOXVkSEpwWW5WMGIzSmZZMjkxYm5RZ1BTQlZTVzUwTmpRb01Da2dJQ01nVG5WdFltVnlJRzltSUdOdmJuUnlhV0oxZEc5eWN3b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVkyOXVkSEpwWW5WMGIzSmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFeUNpQWdJQ0F2THlCamJHRnpjeUJTWVc1MFlXbEJaR2xzS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TndvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnd01tSmxZMlV4TVNBd2VEZG1aR1V6T1dJMElEQjRORGd4Tm1Jek1ESWdNSGhpTURNeE1XSmxZeUF3ZURFeU4yUmpZV0V6SURCNFpERTJZVGN5T1dZZ01IaGlZbUl5TmpaaFlpQXdlREE1WXpjMllqWTRJQzh2SUcxbGRHaHZaQ0FpYUdWc2JHOG9jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMyVjBkWEJmY0hKdmFtVmpkQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSmhaR1JmWTI5dWRISnBZblYwYjNJb1lXUmtjbVZ6Y3l4MWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pzYjJOclgyTnZiblJ5YVdKMWRHOXljeWdwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0ptZFc1a1gzQnliMnBsWTNRb2NHRjVLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMjl0Y0d4bGRHVmZZVzVrWDNCaGVXOTFkQ2dwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZmNISnZhbVZqZEY5emRHRjBkWE1vS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgyTnZiblJ5YVdKMWRHOXlYMk52ZFc1MEtDbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQm9aV3hzYnlCelpYUjFjRjl3Y205cVpXTjBJR0ZrWkY5amIyNTBjbWxpZFhSdmNpQnNiMk5yWDJOdmJuUnlhV0oxZEc5eWN5Qm1kVzVrWDNCeWIycGxZM1FnWTI5dGNHeGxkR1ZmWVc1a1gzQmhlVzkxZENCblpYUmZjSEp2YW1WamRGOXpkR0YwZFhNZ1oyVjBYMk52Ym5SeWFXSjFkRzl5WDJOdmRXNTBDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRjNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlZVzUwWVdsZllXUnBiQzVqYjI1MGNtRmpkQzVTWVc1MFlXbEJaR2xzTG1obGJHeHZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYUdWc2JHODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdjbVYwZFhKdUlDSklaV3hzYnl3Z0lpQXJJRzVoYldVS0lDQWdJSEIxYzJoaWVYUmxjeUFpU0dWc2JHOHNJQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qRXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KaGJuUmhhVjloWkdsc0xtTnZiblJ5WVdOMExsSmhiblJoYVVGa2FXd3VjMlYwZFhCZmNISnZhbVZqZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkSFZ3WDNCeWIycGxZM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVlXNTBZV2xmWVdScGJDOWpiMjUwY21GamRDNXdlVG8xTXkwMU5Bb2dJQ0FnTHk4Z0l5QkZibk4xY21VZ2NISnZhbVZqZENCb1lYTnVKM1FnWW1WbGJpQnpaWFFnZFhBZ2VXVjBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV0WVc1aFoyVnlJRDA5SUVGa1pISmxjM01vS1N3Z0lsQnliMnBsWTNRZ1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdFlXNWhaMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMWhibUZuWlhJZ1pYaHBjM1J6Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUhKdmFtVmpkQ0JoYkhKbFlXUjVJR2x1YVhScFlXeHBlbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklITmxiR1l1YldGdVlXZGxjaUE5SUcxaGJtRm5aWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFoYm1GblpYSWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJSE5sYkdZdVkyeHBaVzUwSUQwZ1kyeHBaVzUwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pqYkdsbGJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXhPVFV3TnpJMlpqWmhOalUyTXpjME1qQTNNelkxTnpRM05UY3dNakEzTXpjMU5qTTJNelkxTnpNM016WTJOelUyWXpJeENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbUZ1ZEdGcFgyRmthV3d1WTI5dWRISmhZM1F1VW1GdWRHRnBRV1JwYkM1aFpHUmZZMjl1ZEhKcFluVjBiM0piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZZMjl1ZEhKcFluVjBiM0k2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUbzNPQzAzT1FvZ0lDQWdMeThnSXlCUGJteDVJRzFoYm1GblpYSWdZMkZ1SUdGa1pDQmpiMjUwY21saWRYUnZjbk1LSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViV0Z1WVdkbGNpd2dJazl1YkhrZ2JXRnVZV2RsY2lCallXNGdZV1JrSUdOdmJuUnlhV0oxZEc5eWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdFlXNWhaMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMWhibUZuWlhJZ1pYaHBjM1J6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diV0Z1WVdkbGNpQmpZVzRnWVdSa0lHTnZiblJ5YVdKMWRHOXljd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pneExUZ3lDaUFnSUNBdkx5QWpJRU5oYm01dmRDQmhaR1FnWTI5dWRISnBZblYwYjNKeklHRm1kR1Z5SUd4dlkydHBibWNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNXBjMTlzYjJOclpXUXNJQ0pEYjI1MGNtbGlkWFJ2Y25NZ2JHbHpkQ0JwY3lCc2IyTnJaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlhWE5mYkc5amEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgyeHZZMnRsWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNTBjbWxpZFhSdmNuTWdiR2x6ZENCcGN5QnNiMk5yWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUbzROQzA0TlFvZ0lDQWdMeThnSXlCV1lXeHBaR0YwWlNCd1pYSmpaVzUwWVdkbENpQWdJQ0F2THlCaGMzTmxjblFnYzJoaGNtVmZjR1Z5WTJWdWRHRm5aU0ErSUZWSmJuUTJOQ2d3S1NCaGJtUWdjMmhoY21WZmNHVnlZMlZ1ZEdGblpTQThQU0JWU1c1ME5qUW9NVEF3S1N3Z0lrbHVkbUZzYVdRZ2NHVnlZMlZ1ZEdGblpTSUtJQ0FnSUdKNklHRmtaRjlqYjI1MGNtbGlkWFJ2Y2w5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnUEQwS0lDQWdJR0o2SUdGa1pGOWpiMjUwY21saWRYUnZjbDlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwaFpHUmZZMjl1ZEhKcFluVjBiM0pmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPamcwTFRnMUNpQWdJQ0F2THlBaklGWmhiR2xrWVhSbElIQmxjbU5sYm5SaFoyVUtJQ0FnSUM4dklHRnpjMlZ5ZENCemFHRnlaVjl3WlhKalpXNTBZV2RsSUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0J6YUdGeVpWOXdaWEpqWlc1MFlXZGxJRHc5SUZWSmJuUTJOQ2d4TURBcExDQWlTVzUyWVd4cFpDQndaWEpqWlc1MFlXZGxJZ29nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2NHVnlZMlZ1ZEdGblpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPamczTFRreUNpQWdJQ0F2THlBaklFTnlaV0YwWlNCdVpYY2dZMjl1ZEhKcFluVjBiM0lLSUNBZ0lDOHZJRzVsZDE5amIyNTBjbWxpZFhSdmNpQTlJRU52Ym5SeWFXSjFkRzl5S0FvZ0lDQWdMeThnSUNBZ0lHRmtaSEpsYzNNOVkyOXVkSEpwWW5WMGIzSmZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J6YUdGeVpWOXdaWEpqWlc1MFlXZGxQWE5vWVhKbFgzQmxjbU5sYm5SaFoyVXNDaUFnSUNBdkx5QWdJQ0FnY0dGcFpEMUdZV3h6WlFvZ0lDQWdMeThnS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2T1RRdE9UVUtJQ0FnSUM4dklDTWdVM1J2Y21VZ2FXNGdZbTk0SUhOMGIzSmhaMlVnZFhOcGJtY2dhVzVrWlhnS0lDQWdJQzh2SUhObGJHWXVZMjl1ZEhKcFluVjBiM0p6VzNObGJHWXVZMjl1ZEhKcFluVjBiM0pmWTI5MWJuUmRJRDBnYm1WM1gyTnZiblJ5YVdKMWRHOXlMbU52Y0hrb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1OdmJuUnlhV0oxZEc5eVgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZiblJ5YVdKMWRHOXlYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pqYjI1MGNtbGlkWFJ2Y25NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPamsyQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZiblJ5YVdKMWRHOXlYMk52ZFc1MElDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1OdmJuUnlhV0oxZEc5eVgyTnZkVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TVdZME16Wm1ObVUzTkRjeU5qazJNamMxTnpRMlpqY3lNakEyTVRZME5qUTJOVFkwTWpBM016YzFOak0yTXpZMU56TTNNelkyTnpVMll6WmpOemt5TVFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaFpHUmZZMjl1ZEhKcFluVjBiM0pmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWVdSa1gyTnZiblJ5YVdKMWRHOXlYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlZVzUwWVdsZllXUnBiQzVqYjI1MGNtRmpkQzVTWVc1MFlXbEJaR2xzTG14dlkydGZZMjl1ZEhKcFluVjBiM0p6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JHOWphMTlqYjI1MGNtbGlkWFJ2Y25NNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNVEV3TFRFeE1Rb2dJQ0FnTHk4Z0l5QlBibXg1SUcxaGJtRm5aWElnWTJGdUlHeHZZMnNLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViV0Z1WVdkbGNpd2dJazl1YkhrZ2JXRnVZV2RsY2lCallXNGdiRzlqYXlCamIyNTBjbWxpZFhSdmNuTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJXRnVZV2RsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRZVzVoWjJWeUlHVjRhWE4wY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzFoYm1GblpYSWdZMkZ1SUd4dlkyc2dZMjl1ZEhKcFluVjBiM0p6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk1URXpMVEV4TkFvZ0lDQWdMeThnSXlCRFlXNXViM1FnYkc5amF5QnBaaUJoYkhKbFlXUjVJR3h2WTJ0bFpBb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1selgyeHZZMnRsWkN3Z0lrRnNjbVZoWkhrZ2JHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbWx6WDJ4dlkydGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMxOXNiMk5yWldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCc2IyTnJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE1UWXRNVEUzQ2lBZ0lDQXZMeUFqSUUxMWMzUWdhR0YyWlNCaGRDQnNaV0Z6ZENCdmJtVWdZMjl1ZEhKcFluVjBiM0lLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1OdmJuUnlhV0oxZEc5eVgyTnZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlUbThnWTI5dWRISnBZblYwYjNKeklHRmtaR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU52Ym5SeWFXSjFkRzl5WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiMjUwY21saWRYUnZjbDlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCamIyNTBjbWxpZFhSdmNuTWdZV1JrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUb3hNVGt0TVRJd0NpQWdJQ0F2THlBaklGWmhiR2xrWVhSbElIUm9ZWFFnYzJoaGNtVnpJSE4xYlNCMGJ5QXhNREFsQ2lBZ0lDQXZMeUIwYjNSaGJGOXdaWEpqWlc1MFlXZGxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hObGJHWXVZMjl1ZEhKcFluVjBiM0pmWTI5MWJuUXBPZ29nSUNBZ1pIVndDZ3BzYjJOclgyTnZiblJ5YVdKMWRHOXljMTltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jMlZzWmk1amIyNTBjbWxpZFhSdmNsOWpiM1Z1ZENrNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJzYjJOclgyTnZiblJ5YVdKMWRHOXljMTloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdZMjl1ZEhKcFluVjBiM0lnUFNCelpXeG1MbU52Ym5SeWFXSjFkRzl5YzF0cFhTNWpiM0I1S0NrS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVkyOXVkSEpwWW5WMGIzSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIyNTBjbWxpZFhSdmNuTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QjBiM1JoYkY5d1pYSmpaVzUwWVdkbElDczlJR052Ym5SeWFXSjFkRzl5TG5Ob1lYSmxYM0JsY21ObGJuUmhaMlVLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE1qRUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoelpXeG1MbU52Ym5SeWFXSjFkRzl5WDJOdmRXNTBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2JHOWphMTlqYjI1MGNtbGlkWFJ2Y25OZlptOXlYMmhsWVdSbGNrQXlDZ3BzYjJOclgyTnZiblJ5YVdKMWRHOXljMTloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBiM1JoYkY5d1pYSmpaVzUwWVdkbElEMDlJRlZKYm5RMk5DZ3hNREFwTENBaVUyaGhjbVZ6SUcxMWMzUWdjM1Z0SUhSdklERXdNQ1VpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJREV3TUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRhR0Z5WlhNZ2JYVnpkQ0J6ZFcwZ2RHOGdNVEF3SlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qRXlOd29nSUNBZ0x5OGdjMlZzWmk1cGMxOXNiMk5yWldRZ1BTQlVjblZsQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pwYzE5c2IyTnJaV1FpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREpqTkRNMlpqWmxOelEzTWpZNU5qSTNOVGMwTm1ZM01qY3pNakEyWXpZNU56TTNOREl3Tm1NMlpqWXpObUkyTlRZME1qRXlNRFV5TmpVMk1UWTBOemt5TURZMk5tWTNNakl3TmpZM05UWmxOalEyT1RabE5qY3laUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KaGJuUmhhVjloWkdsc0xtTnZiblJ5WVdOMExsSmhiblJoYVVGa2FXd3VablZ1WkY5d2NtOXFaV04wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1puVnVaRjl3Y205cVpXTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUb3hORE10TVRRMENpQWdJQ0F2THlBaklFOXViSGtnWTJ4cFpXNTBJR05oYmlCbWRXNWtDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtTnNhV1Z1ZEN3Z0lrOXViSGtnWTJ4cFpXNTBJR05oYmlCbWRXNWtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnNhV1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiR2xsYm5RZ1pYaHBjM1J6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZMnhwWlc1MElHTmhiaUJtZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNVFEyTFRFME53b2dJQ0FnTHk4Z0l5QkRiMjUwY21saWRYUnZjbk1nYlhWemRDQmlaU0JzYjJOclpXUWdabWx5YzNRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYMnh2WTJ0bFpDd2dJa052Ym5SeWFXSjFkRzl5Y3lCdGRYTjBJR0psSUd4dlkydGxaQ0JtYVhKemRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGMxOXNiMk5yWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mYkc5amEyVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUVOdmJuUnlhV0oxZEc5eWN5QnRkWE4wSUdKbElHeHZZMnRsWkNCbWFYSnpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFME9TMHhOVEFLSUNBZ0lDOHZJQ01nUTJGdWJtOTBJR1oxYm1RZ2FXWWdZV3h5WldGa2VTQmpiMjF3YkdWMFpXUUtJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdjMlZzWmk1cGMxOWpiMjF3YkdWMFpXUXNJQ0pRY205cVpXTjBJR0ZzY21WaFpIa2dZMjl0Y0d4bGRHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltbHpYMk52YlhCc1pYUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMxOWpiMjF3YkdWMFpXUWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVSEp2YW1WamRDQmhiSEpsWVdSNUlHTnZiWEJzWlhSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakUxTWkweE5UTUtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlIQmhlVzFsYm5RZ1oyOWxjeUIwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWxCaGVXMWxiblFnYlhWemRDQm5ieUIwYnlCamIyNTBjbUZqZENJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCbmJ5QjBieUJqYjI1MGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFMU5TMHhOVFlLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJSEJoZVcxbGJuUWdZVzF2ZFc1MElHbHpJSEpsWVhOdmJtRmliR1VnS0dGMElHeGxZWE4wSURFZ1FVeEhUeWtLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtRnRiM1Z1ZENBK1BTQlZTVzUwTmpRb01WOHdNREJmTURBd0tTd2dJazFwYm1sdGRXMGdablZ1WkdsdVp5QnBjeUF4SUVGTVIwOGlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdJQzh2SURFd01EQXdNREFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RXbHVhVzExYlNCbWRXNWthVzVuSUdseklERWdRVXhIVHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qRTFPQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjltZFc1a1pXUWdLejBnY0dGNWJXVnVkQzVoYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjltZFc1a1pXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZablZ1WkdWa0lHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZlpuVnVaR1ZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURGak5UQTNNalptTm1FMk5UWXpOelF5TURZMk56VTJaVFkwTmpVMk5ESXdOek0zTlRZek5qTTJOVGN6TnpNMk5qYzFObU0yWXpjNU1qRUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WVc1MFlXbGZZV1JwYkM1amIyNTBjbUZqZEM1U1lXNTBZV2xCWkdsc0xtTnZiWEJzWlhSbFgyRnVaRjl3WVhsdmRYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjIxd2JHVjBaVjloYm1SZmNHRjViM1YwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVlXNTBZV2xmWVdScGJDOWpiMjUwY21GamRDNXdlVG94TnpFdE1UY3lDaUFnSUNBdkx5QWpJRTl1YkhrZ2JXRnVZV2RsY2lCdmNpQmpiR2xsYm5RZ1kyRnVJR052YlhCc1pYUmxDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtMWhibUZuWlhJZ2IzSWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbU5zYVdWdWRDd2dJazl1YkhrZ2JXRnVZV2RsY2lCdmNpQmpiR2xsYm5RZ1kyRnVJR052YlhCc1pYUmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhibUZuWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0Z1WVdkbGNpQmxlR2x6ZEhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaWJub2dZMjl0Y0d4bGRHVmZZVzVrWDNCaGVXOTFkRjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU5zYVdWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYkdsbGJuUWdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMjl0Y0d4bGRHVmZZVzVrWDNCaGVXOTFkRjlpYjI5c1gyWmhiSE5sUURRS0NtTnZiWEJzWlhSbFgyRnVaRjl3WVhsdmRYUmZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWTI5dGNHeGxkR1ZmWVc1a1gzQmhlVzkxZEY5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRjeExURTNNZ29nSUNBZ0x5OGdJeUJQYm14NUlHMWhibUZuWlhJZ2IzSWdZMnhwWlc1MElHTmhiaUJqYjIxd2JHVjBaUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXRZVzVoWjJWeUlHOXlJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVqYkdsbGJuUXNJQ0pQYm14NUlHMWhibUZuWlhJZ2IzSWdZMnhwWlc1MElHTmhiaUJqYjIxd2JHVjBaU0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUcxaGJtRm5aWElnYjNJZ1kyeHBaVzUwSUdOaGJpQmpiMjF3YkdWMFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakUzTkMweE56VUtJQ0FnSUM4dklDTWdVSEp2YW1WamRDQnRkWE4wSUdKbElHWjFibVJsWkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWRHOTBZV3hmWm5WdVpHVmtJRDRnVlVsdWREWTBLREFwTENBaVVISnZhbVZqZENCdWIzUWdablZ1WkdWa0lIbGxkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5bWRXNWtaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWm5WdVpHVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUZCeWIycGxZM1FnYm05MElHWjFibVJsWkNCNVpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVlXNTBZV2xmWVdScGJDOWpiMjUwY21GamRDNXdlVG94TnpjdE1UYzRDaUFnSUNBdkx5QWpJRU5oYm01dmRDQmpiMjF3YkdWMFpTQjBkMmxqWlFvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCelpXeG1MbWx6WDJOdmJYQnNaWFJsWkN3Z0lsQnliMnBsWTNRZ1lXeHlaV0ZrZVNCamIyMXdiR1YwWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZlkyOXRjR3hsZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6WDJOdmJYQnNaWFJsWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOXFaV04wSUdGc2NtVmhaSGtnWTI5dGNHeGxkR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk1UZ3dMVEU0TVFvZ0lDQWdMeThnSXlCUVlYa2daV0ZqYUNCamIyNTBjbWxpZFhSdmNpQjBhR1ZwY2lCemFHRnlaUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1WTI5dWRISnBZblYwYjNKZlkyOTFiblFwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU52Ym5SeWFXSjFkRzl5WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXVkSEpwWW5WMGIzSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F5Q2dwamIyMXdiR1YwWlY5aGJtUmZjR0Y1YjNWMFgyWnZjbDlvWldGa1pYSkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE9EQXRNVGd4Q2lBZ0lDQXZMeUFqSUZCaGVTQmxZV05vSUdOdmJuUnlhV0oxZEc5eUlIUm9aV2x5SUhOb1lYSmxDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2MyVnNaaTVqYjI1MGNtbGlkWFJ2Y2w5amIzVnVkQ2s2Q2lBZ0lDQmtkWEF5Q2lBZ0lDQThDaUFnSUNCaWVpQmpiMjF3YkdWMFpWOWhibVJmY0dGNWIzVjBYMkZtZEdWeVgyWnZja0F4TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qRTRNZ29nSUNBZ0x5OGdZMjl1ZEhKcFluVjBiM0lnUFNCelpXeG1MbU52Ym5SeWFXSjFkRzl5YzF0cFhTNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKamIyNTBjbWxpZFhSdmNuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dOUW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1ZEhKcFluVjBiM0p6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnYVdZZ2JtOTBJR052Ym5SeWFXSjFkRzl5TG5CaGFXUTZDaUFnSUNCd2RYTm9hVzUwSURNeU1DQXZMeUF6TWpBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW01NklHTnZiWEJzWlhSbFgyRnVaRjl3WVhsdmRYUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakU0TlMweE9EWUtJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJSEJoZVc5MWRDQmhiVzkxYm5RS0lDQWdJQzh2SUhCaGVXOTFkRjloYlc5MWJuUWdQU0FvYzJWc1ppNTBiM1JoYkY5bWRXNWtaV1FnS2lCamIyNTBjbWxpZFhSdmNpNXphR0Z5WlY5d1pYSmpaVzUwWVdkbEtTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyWjFibVJsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5bWRXNWtaV1FnWlhocGMzUnpDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNVGc0TFRFNU13b2dJQ0FnTHk4Z0l5QlRaVzVrSUhCaGVXMWxiblFnZG1saElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5WTI5dWRISnBZblYwYjNJdVlXUmtjbVZ6Y3k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhCaGVXOTFkRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTQWdJeUJEYjI1MGNtRmpkQ0J3WVhseklIUm9aU0JtWldVS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE9UQUtJQ0FnSUM4dklISmxZMlZwZG1WeVBXTnZiblJ5YVdKMWRHOXlMbUZrWkhKbGMzTXVibUYwYVhabExBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakU0T0MweE9Ea0tJQ0FnSUM4dklDTWdVMlZ1WkNCd1lYbHRaVzUwSUhacFlTQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKaGJuUmhhVjloWkdsc0wyTnZiblJ5WVdOMExuQjVPakU1TWdvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTQWdJeUJEYjI1MGNtRmpkQ0J3WVhseklIUm9aU0JtWldVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qRTRPQzB4T1RNS0lDQWdJQzh2SUNNZ1UyVnVaQ0J3WVhsdFpXNTBJSFpwWVNCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQV052Ym5SeWFXSjFkRzl5TG1Ga1pISmxjM011Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrZ0lDTWdRMjl1ZEhKaFkzUWdjR0Y1Y3lCMGFHVWdabVZsQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFNU5TMHhPVGNLSUNBZ0lDOHZJQ01nVFdGeWF5QmhjeUJ3WVdsa0NpQWdJQ0F2THlCamIyNTBjbWxpZFhSdmNpNXdZV2xrSUQwZ1ZISjFaUW9nSUNBZ0x5OGdjMlZzWmk1amIyNTBjbWxpZFhSdmNuTmJhVjBnUFNCamIyNTBjbWxpZFhSdmNpNWpiM0I1S0NrS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOREFnTHk4Z05EQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE9UVXRNVGsyQ2lBZ0lDQXZMeUFqSUUxaGNtc2dZWE1nY0dGcFpBb2dJQ0FnTHk4Z1kyOXVkSEpwWW5WMGIzSXVjR0ZwWkNBOUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TVRrMUxURTVOd29nSUNBZ0x5OGdJeUJOWVhKcklHRnpJSEJoYVdRS0lDQWdJQzh2SUdOdmJuUnlhV0oxZEc5eUxuQmhhV1FnUFNCVWNuVmxDaUFnSUNBdkx5QnpaV3htTG1OdmJuUnlhV0oxZEc5eWMxdHBYU0E5SUdOdmJuUnlhV0oxZEc5eUxtTnZjSGtvS1FvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb0tZMjl0Y0d4bGRHVmZZVzVrWDNCaGVXOTFkRjloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmhiblJoYVY5aFpHbHNMMk52Ym5SeVlXTjBMbkI1T2pFNE1DMHhPREVLSUNBZ0lDOHZJQ01nVUdGNUlHVmhZMmdnWTI5dWRISnBZblYwYjNJZ2RHaGxhWElnYzJoaGNtVUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoelpXeG1MbU52Ym5SeWFXSjFkRzl5WDJOdmRXNTBLVG9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXlDaUFnSUNCaUlHTnZiWEJzWlhSbFgyRnVaRjl3WVhsdmRYUmZabTl5WDJobFlXUmxja0EyQ2dwamIyMXdiR1YwWlY5aGJtUmZjR0Y1YjNWMFgyRm1kR1Z5WDJadmNrQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveE9Ua0tJQ0FnSUM4dklITmxiR1l1YVhOZlkyOXRjR3hsZEdWa0lEMGdWSEoxWlFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZlkyOXRjR3hsZEdWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21GdWRHRnBYMkZrYVd3dlkyOXVkSEpoWTNRdWNIazZNVFl5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeU9UVXdOekkyWmpaaE5qVTJNemMwTWpBMk16Wm1ObVEzTURaak5qVTNORFkxTmpReU1USXdOREUyWXpaak1qQTJNelptTm1VM05EY3lOamsyTWpjMU56UTJaamN5TnpNeU1EY3dOakUyT1RZME1tVUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZMjl0Y0d4bGRHVmZZVzVrWDNCaGVXOTFkRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJqYjIxd2JHVjBaVjloYm1SZmNHRjViM1YwWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WVc1MFlXbGZZV1JwYkM1amIyNTBjbUZqZEM1U1lXNTBZV2xCWkdsc0xtZGxkRjl3Y205cVpXTjBYM04wWVhSMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5d2NtOXFaV04wWDNOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveU1URUtJQ0FnSUM4dklHbG1JRzV2ZENCelpXeG1MbWx6WDJ4dlkydGxaRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnBjMTlzYjJOclpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmJHOWphMlZrSUdWNGFYTjBjd29nSUNBZ1ltNTZJR2RsZEY5d2NtOXFaV04wWDNOMFlYUjFjMTlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qSXhNZ29nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVUzUmhkSFZ6T2lCVFpYUjBhVzVuSUhWd0lHTnZiblJ5YVdKMWRHOXljeUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbE4wWVhSMWN6b2dVMlYwZEdsdVp5QjFjQ0JqYjI1MGNtbGlkWFJ2Y25NaUNncG5aWFJmY0hKdmFtVmpkRjl6ZEdGMGRYTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11Y21GdWRHRnBYMkZrYVd3dVkyOXVkSEpoWTNRdVVtRnVkR0ZwUVdScGJDNW5aWFJmY0hKdmFtVmpkRjl6ZEdGMGRYTkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlZVzUwWVdsZllXUnBiQzlqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5d2NtOXFaV04wWDNOMFlYUjFjMTlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WVc1MFlXbGZZV1JwYkM5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJR1ZzYVdZZ2MyVnNaaTUwYjNSaGJGOW1kVzVrWldRZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDJaMWJtUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjltZFc1a1pXUWdaWGhwYzNSekNpQWdJQ0JpYm5vZ1oyVjBYM0J5YjJwbFkzUmZjM1JoZEhWelgyVnNjMlZmWW05a2VVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpFMENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pUZEdGMGRYTTZJRmRoYVhScGJtY2dabTl5SUdaMWJtUnBibWNpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUZEdGMGRYTTZJRmRoYVhScGJtY2dabTl5SUdaMWJtUnBibWNpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk1qQXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSWdaMlYwWDNCeWIycGxZM1JmYzNSaGRIVnpYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5KaGJuUmhhVjloWkdsc0xtTnZiblJ5WVdOMExsSmhiblJoYVVGa2FXd3VaMlYwWDNCeWIycGxZM1JmYzNSaGRIVnpRRGdLQ21kbGRGOXdjbTlxWldOMFgzTjBZWFIxYzE5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVlXNTBZV2xmWVdScGJDOWpiMjUwY21GamRDNXdlVG95TVRVS0lDQWdJQzh2SUdWc2FXWWdibTkwSUhObGJHWXVhWE5mWTI5dGNHeGxkR1ZrT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbWx6WDJOdmJYQnNaWFJsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjMTlqYjIxd2JHVjBaV1FnWlhocGMzUnpDaUFnSUNCaWJub2daMlYwWDNCeWIycGxZM1JmYzNSaGRIVnpYMlZzYzJWZlltOWtlVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbUZ1ZEdGcFgyRmthV3d2WTI5dWRISmhZM1F1Y0hrNk1qRTJDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKVGRHRjBkWE02SUVaMWJtUmxaQ3dnWVhkaGFYUnBibWNnWTI5dGNHeGxkR2x2YmlJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOMFlYUjFjem9nUm5WdVpHVmtMQ0JoZDJGcGRHbHVaeUJqYjIxd2JHVjBhVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qSXdNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmlJR2RsZEY5d2NtOXFaV04wWDNOMFlYUjFjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1eVlXNTBZV2xmWVdScGJDNWpiMjUwY21GamRDNVNZVzUwWVdsQlpHbHNMbWRsZEY5d2NtOXFaV04wWDNOMFlYUjFjMEE0Q2dwblpYUmZjSEp2YW1WamRGOXpkR0YwZFhOZlpXeHpaVjlpYjJSNVFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpFNENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pUZEdGMGRYTTZJRU52YlhCc1pYUmxaQ0JoYm1RZ2NHRnBaQ0J2ZFhRaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVGRHRjBkWE02SUVOdmJYQnNaWFJsWkNCaGJtUWdjR0ZwWkNCdmRYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpBekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdJZ1oyVjBYM0J5YjJwbFkzUmZjM1JoZEhWelgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpoYm5SaGFWOWhaR2xzTG1OdmJuUnlZV04wTGxKaGJuUmhhVUZrYVd3dVoyVjBYM0J5YjJwbFkzUmZjM1JoZEhWelFEZ0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21GdWRHRnBYMkZrYVd3dVkyOXVkSEpoWTNRdVVtRnVkR0ZwUVdScGJDNW5aWFJmWTI5dWRISnBZblYwYjNKZlkyOTFiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZMjl1ZEhKcFluVjBiM0pmWTI5MWJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtRnVkR0ZwWDJGa2FXd3ZZMjl1ZEhKaFkzUXVjSGs2TWpJNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWpiMjUwY21saWRYUnZjbDlqYjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1OdmJuUnlhV0oxZEc5eVgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZiblJ5YVdKMWRHOXlYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0poYm5SaGFWOWhaR2xzTDJOdmJuUnlZV04wTG5CNU9qSXlNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ1pDWUlCMjFoYm1GblpYSU1kRzkwWVd4ZlpuVnVaR1ZrQ1dselgyeHZZMnRsWkJGamIyNTBjbWxpZFhSdmNsOWpiM1Z1ZEF4cGMxOWpiMjF3YkdWMFpXUUdZMnhwWlc1MEJCVWZmSFVNWTI5dWRISnBZblYwYjNKek1SaEFBQllvTWdObkp3VXlBMmNwSW1jcUltY25CQ0puS3lKbk1SdEJBRWN4R1JSRU1SaEVnZ2dFQXI3T0VRUi8zam0wQkVnV3N3SUVzREViN0FRU2ZjcWpCTkZxY3A4RXU3Sm1xd1FKeDJ0b05ob0FqZ2dBQ3dBMkFIb0E4QUZtQWNRQ2hRTTJBREVaRkRFWUZCQkVJME0yR2dGSklsbUJBZ2hMQVJVU1JGY0NBSUFIU0dWc2JHOHNJRXhRU1JVV1Z3WUNURkFuQmt4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JDSW9aVVF5QXhKRUtFOENaeWNGVEdlQUh4VWZmSFVBR1ZCeWIycGxZM1FnYzJWMGRYQWdjM1ZqWTJWemMyWjFiQ0d3STBNMkdnRkpGU1FTUkRZYUFra1ZnUWdTUkJkSklpaGxSREVBRWtRaUttVkVGRVJCQUU1SkpRNUJBRWdqUkVrV1N3Sk1VSUFCQUZBaUsyVkVTUlluQjB4UVR3Sy9Jd2dyVEdlQUpSVWZmSFVBSDBOdmJuUnlhV0oxZEc5eUlHRmtaR1ZrSUhOMVkyTmxjM05tZFd4c2VTR3dJME1pUXYrMUlpaGxSREVBRWtRaUttVkVGRVFpSzJWTVNVOENSRVFpU1VsTEF3eEJBQmRIQWhZbkIweFF2a1FrVzBzRENFVURJd2hGQVVMLzRrc0JKUkpFS2lObmdESVZIM3gxQUN4RGIyNTBjbWxpZFhSdmNuTWdiR2x6ZENCc2IyTnJaV1FoSUZKbFlXUjVJR1p2Y2lCbWRXNWthVzVuTHJBalF6RVdJd2xKT0JBakVrUWlKd1ZsUkRFQUVrUWlLbVZFUkNJbkJHVkVGRVJKT0FjeUNoSkVPQWhKZ2NDRVBROUVJaWxsUkFncFRHZUFJaFVmZkhVQUhGQnliMnBsWTNRZ1puVnVaR1ZrSUhOMVkyTmxjM05tZFd4c2VTR3dJME1pU1lBQVNTSW9aVVF4QUJKQUFBc2lKd1ZsUkRFQUVrRUFveU5FSWlsbFJFUWlKd1JsUkJSRUlpdGxURVVDUkNKRkFrb01RUUJPU3dFV0p3ZE1VRWxGQmI1TVNVNENSUVZFZ2NBQ1UwQUFMQ0lwWlVSTEEwbE9BaVJiQ3lVS3NVeFhBQ0N5QjdJSUk3SVFJcklCczBzRFNZRW9JN29pSTFTQktFeTdTd0VqQ0VVQ1F2K3RKd1FqWjRBdkZSOThkUUFwVUhKdmFtVmpkQ0JqYjIxd2JHVjBaV1FoSUVGc2JDQmpiMjUwY21saWRYUnZjbk1nY0dGcFpDNndJME1pUXY5YUlpcGxSRUFBTUlBZlUzUmhkSFZ6T2lCVFpYUjBhVzVuSUhWd0lHTnZiblJ5YVdKMWRHOXljMGtWRmxjR0FreFFKd1pNVUxBalF5SXBaVVJBQUNDQUcxTjBZWFIxY3pvZ1YyRnBkR2x1WnlCbWIzSWdablZ1WkdsdVowTC95aUluQkdWRVFBQW9nQ05UZEdGMGRYTTZJRVoxYm1SbFpDd2dZWGRoYVhScGJtY2dZMjl0Y0d4bGRHbHZia0wvbW9BZVUzUmhkSFZ6T2lCRGIyMXdiR1YwWldRZ1lXNWtJSEJoYVdRZ2IzVjBRdjkzSWl0bFJCWW5Ca3hRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
