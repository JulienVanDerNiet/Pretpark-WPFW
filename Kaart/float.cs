namespace Kaart;

public static class FloatExtension{
    public static string MetSuffix(this float value, string suffix){
        return $"{value:F2}{suffix}";
    }
}