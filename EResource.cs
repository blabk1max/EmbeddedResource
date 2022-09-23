class EResource {

  public EResource() {

  }

  public static string LoadResource() {

    var res = "";

    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
    var stream = assembly.GetManifestResourceStream("ResourceA");
    if (stream == null) {
      return "リソース取得は失敗";
    }
    using(var reader = new StreamReader(stream)) {
      res = reader.ReadToEnd();
    }
    return res;
  }
}