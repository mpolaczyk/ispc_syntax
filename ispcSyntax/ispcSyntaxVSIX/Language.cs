
namespace ispcSyntax
{
  class Language
  {
    public static string[] Keywords =
    { 
        // Keywords
        "static","inline","noinline","const","unmasked",
        "typedef","return","export","default","extern","sizeof",
        "ignore","warning",
        "in", "__regcall", "__vectorcall", "print", "soa", "invoke_sycl",
        "class","struct","enum","union",
        "true","false","unsigned","signed",
        // Operators Overloading
        "operator",
        // Dynamic Memory Allocation
        "delete","new","new[]","delete[]",
        // Control Flow
        "if","else","case","switch",
        // Unstructured Control Flow
        "goto",
        // "Coherent" Control Flow
        "cdo", "cfor", "cif", "cwhile",
        // Iteration Statements
        "for","while","do","foreach","foreach_tiled","foreach_active","foreach_unique","break","continue","...",
        // Parallel Iteration
        "programIndex", "programCount",
        // Task Parallelism
        "launch","sync","task",
        // Function Templates
        "template","typename",

    };
        public static string[] Types =
        {
        // Types
        "void",
        "uniform","varying", "vec",
        "double",
        "float","float16",
        "int","int8","int16","int32","int64",
        "uint8", "uint16", "uint32", "uint64",
        "bool",
        "NULL", "size_t", "ptrdiff_t", "intptr_t", "uintptr_t",
        };
        public static string[] Identifiers =
        {
        // Logical and Selection Operations
        "and","or","select",
        // Bit Operations 
        "popcnt","count_leading_zeros","count_trailing_zeros","sign_extend","packmask","intbits","float16bits","floatbits","doublebits",
        // Basic Math Functions
        "abs","signbits","round","floor","ceil","trunc","rcp","rcp_fast","min","max","clamp","isnan","avg_up","avg_down",
        // Transcendental Functions
        "sqrt","rsqrt","rsqrt_fast","rsqrt_fast","sin","cos","tan","acos","asin","atan","atan2","sincos","exp","log","pow","ldexp","frexp",
        // Saturating Arithmetic
        "saturating_add","saturating_sub","saturating_mul","saturating_div",
        // Random Numbers
        "rdrand","frandom","random","seed_rng",
        // Assertions
        "assert","abort",
        // Compiler Optimization Hints
        "assume","unroll","nounroll",
        // Cross-Program Instance Operations
        "broadcast", "rotate","shift","shuffle","extract","insert",    
        // Reductions
        "any","all","none","reduce_add","reduce_min","reduce_max","reduce_equal","exclusive_scan_add","exclusive_scan_or",
        // Stack Memory Allocation
        "alloca",
        // Setting and Copying Values In Memory
        "memcpy","memmove","memset","memcpy64","memmove64","memset64",
        // Packed Load and Store Operations
        "packed_load_active","packed_store_active",
        // Streaming Load and Store Operations
        "streaming_store","streaming_load","streaming_load_uniform"
        };
        public static string[] PreprocessorKeywords =
        {
            "#include", "#define", "#undef", "#ifdef","#ifndef","#stdout", "#error", "#pragma", "#if", "#elif", "#endif", ""
        };
        public static string Operators = "!+-*/\\=<>&|`";
        public static string[] IndentationUp =
        {
            "{"
        };
        public static string[] IndentationDown =
        {
            "}"
        };
        public static bool IsLineIndentationUp(string Line)
        {
            foreach(string token in IndentationUp)
            {
                if(Line.TrimStart().StartsWith(token))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsLineIndentationDown(string Line)
        {
            foreach (string token in IndentationDown)
            {
                if (Line.TrimStart().StartsWith(token))
                {
                    return true;
                }
            }
            return false;
        }
    }


}
