# MStest_NUnit_xUnit.net_Compare
## Attributes
<span style="color:red">我自己整理的比較表如下，如果有錯誤，還請各位大大指導，謝謝</span>
    
MSTest (v1)|NUnit 3|xUnit.net 2.x|Comments
:-|:-|:-|:-
[AssemblyCleanup]|n/a|n/a|識別方法，該方法包含組件中的所有測試都執行完畢後，為釋放此組件所佔用資源而要使用的程式碼。
[AssemblyInitialize]|n/a|n/a|識別方法，該方法所包含的程式碼用於已執行組件中的所有測試之前，以便配置此組件所佔用的資源。
[ClassCleanup]|[OneTimeTearDown]|IClassFixture<T>|指定測試執行後的結束方法，一個測試 class 只執行一次
[ClassInitialize]|[OneTimeSetUp]|IClassFixture<T>|指定測試執行前的起始方法，一個測試 class 只執行一次
[CssIteration]|Repeat||表示這個測試所對應的專案反覆項目。
[CssProjectStructure]|n/a|n/a|表示這個測試所對應到之 Team 專案階層架構中的節點。
[DataSource]|[Theory]|[Theory]<br/>[xxxData]"|data-driven test
[DeploymentItem]|n/a|n/a|指定應該在執行測試之前的組件一起部署的檔案或目錄。附加這個屬性對測試類別和測試方法。您可以使用多個執行個體。
[Description]|[Description]|n/a|用來指定測試的說明。
[ExpectedException]|Throws.TypeOf<Exception>()|Assert.Throws<br/>Record.Exception"|測試的對象出現 exception Nunit 3 與 xUnit.net 都是直接從 code 處理掉，是比較方便直覺的
[ExpectedExceptionBase]|n/a|n/a|這是屬性的基底類別，這些屬性指定單元測試應擲回預期的例外狀況。
[HostType]|platform 有包含相關功該|n/a|指定將執行相關聯單元測試的主機的類型。
[Ignore]|[Ignore]|[Fact(Skip="reason")]|用來標示忽略該測試
[Owner]|[Author]|n/a|用來指定負責維護、執行和/或偵錯測試的人員。
[Priority]|[Order]|n/a|用來指定單元測試的優先權。
[TestCategory]|[Category]|n/a|用來指定單元測試分類別的類別。
[TestCategoryBase]|n/a|n/a|提供分類屬性的基底類別。
[TestClass]|[TestFixture]|n/a|將 class 標示測試 class. 特別的是 xUnit.net 不需要加上這樣的 attibute 會自動去搜尋所有 public class 中的測試方法，但這樣一來也代表著速度會受到影響;
[TestClassExtension]|n/a|n/a|啟動類別，以便將其辨認為單元測試延伸模組類別。
[TestCleanup]|[TearDown]|IDisposable.Dispose|指定測試執行後的方法，常用來清除測試產生的資料，每個測試皆會執行一次
[TestInitialize]|[SetUp]|Constructor|指定測試執行前的起始方法，常用來設定測試用的初始值，每個測試皆會執行一次
[TestMethod]|[Test]|[Fact]|標記為測試方法
[TestProperty]|[Property]|[Trait]|用來指定共用的測試屬性
[Timeout]|[Timeout]|n/a|用來指定單元測試的逾時期間。
[WorkItem]|n/a|n/a|用來指定與測試相關聯的工作項目。
n/a|[TestFixtureSource]|ICollectionFixture<T>|用來與其他測試共用物件
n/a|[Apartment]|n/a|可以使用在組件、class、method，用來指定測試執行的模式-STA(Single-threaded apartment)/MTA(Multi-threaded apartment)
n/a|[Combinatorial]|n/a|給定參數集合，會自動產生所有參數組合的測試
n/a|[Culture]|n/a|說明測試應該使用的語系，不會直接修改語系
n/a|[Datapoint]|n/a|為 theory 方法提供測試資料
n/a|[DatapointSource]|n/a|為 theory 方法提供測試資料，資料為集合或是陣列(ienumerable)
n/a|[Explicit]|n/a|如果沒有特別選定執行，預設為不執行
n/a|[LevelOfParallelism]|n/a|平行測試的 thread 數，組件層級的 attribute，預設值是 cpu 核心數或是2(看哪個比較大)
n/a|[Maxtime]|n/a|指定測試最大可以執行時間(單位：毫秒)，超出時間即為失敗，仍會執行結束
n/a|[Pairwise]|n/a|會產生所有參數的兩兩對應測試組合;combinatorial 適用於兩組參數,PairwiseAttribute 則適用於兩組以上
n/a|[Parallelizable]|n/a|用來標示哪些測試要平行執行(會影響下層),可以指定影響範圍 (None-不使用平行執行;Self-自己與其他測試使用平行執行;Choldren-所屬下層測試使用平行測試;Fixture-使用平行測試);ParallelScope.Self 是預設值;並未實作於 method 這層(ParallelizableAttribute 套用在 method 上會被忽略);ParallelScope.Children 與 ParallelScope.Fixtures 功能相同
n/a|[Platform]|n/a|用來指定測試的平台，詳細清單可以參考 https://github.com/nunit/docs/wiki/Platform-Attribute
n/a|[Random]|n/a|產生隨機參數來測試
n/a|[Range]|n/a|將範圍內所有可能參數代入測試
n/a|[RequiresThread]|n/a|以獨立的 thread 來執行測試
n/a|[Retry]|n/a|失敗重試
n/a|[Sequential]|n/a|將參數組合依序執行，而不是對所有組合執行 e.g. [a,b,c]*[1,2,3] --> a-1,b-2,c-3
n/a|[SetCulture]|n/a|指定語言
n/a|[SetUICulture]|n/a|指定 UI 顯示語言
n/a|[SetUpFixture]|n/a|讓 class 在同一個 namespace 中有一次性的統一起始(setup)或是結束(teardown)行為
n/a|[SingleThreaded]|n/a|用來將 class 中的測試方法在同個 thread 中執行，Nunit 3.6 才加入
n/a|[TestCase]|n/a|給定測試案例參數來進行測試
n/a|[TestCaseSource]|n/a|先定義測試案例參數，然後將參數指定給 method 來測試
n/a|[TestOf]|n/a|用來標示是哪個 class 的測試
n/a|[Values]|n/a|為測試方法指定參數-用在描述 method 的參數
n/a|[ValueSource]|n/a|先定義參數資料，再指定給 method 來進行測試，可以給自訂型別 - 用在描述 method 的參數

## Assertions
<span style="color:red">我自己整理的比較表如下，如果有錯誤，還請各位大大指導，謝謝</span>

MSTest (v1)|NUnit 3|xUnit.net 2.x
:-|:-|:-
AreEqual|AreEqual|Equal
AreNotEqual|AreNotEqual|NotEqual
AreNotSame|AreNotSame|NotSame
AreSame|AreSame|Same
Equals|n/a|Equals
Fail|n/a|n/a
Inconclusive|Inconclusive|n/a
IsFalse|False|False
IsInstanceOfType|IsInstanceOf|IsType
IsNotInstanceOfType|IsNotInstanceOf|IsNotType
IsNotNull|NotNull|NotNull
IsNull|Null|Null
IsTrue|True|True
ReplaceNullChars|n/a|n/a
n/a|Catch|n/a
n/a|CatchAsync|n/a
n/a|Contains|Contains
n/a|DoesNotThrow|n/a
n/a|DoesNotThrowAsync|n/a
n/a|Fail|n/a
n/a|Greater|n/a
n/a|GreaterOrEqual|n/a
n/a|Ignore|n/a
n/a|IsAssignableFrom|n/a
n/a|IsEmpty|Empty
n/a|IsNaN|n/a
n/a|IsNotAssignableFrom|n/a
n/a|IsNotEmpty|NotEmpty
n/a|Less|n/a
n/a|LessOrEqual|n/a
n/a|Pass|n/a
n/a|Throws|Throws
n/a|ThrowsAsync|ThrowsAsync
n/a|n/a|All
n/a|n/a|Collection
n/a|n/a|DoesNotContain
n/a|n/a|DoesNotMatch
n/a|n/a|EndsWith
n/a|n/a|InRange
n/a|n/a|IsAssignableFrom
n/a|n/a|Matches
n/a|n/a|NotInRange
n/a|n/a|NotStrictEqual
n/a|n/a|ProperSubset
n/a|n/a|ProperSuperset
n/a|n/a|PropertyChanged
n/a|n/a|ReferenceEquals
n/a|n/a|Single
n/a|n/a|StartsWith
n/a|n/a|StrictEqual
n/a|n/a|Subset
n/a|n/a|Superset
n/a|n/a|ThrowsAny
n/a|n/a|ThrowsAnyAsync
