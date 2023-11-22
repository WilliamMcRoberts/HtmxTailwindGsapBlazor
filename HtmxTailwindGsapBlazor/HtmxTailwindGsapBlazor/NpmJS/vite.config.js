export default {
    root: 'NpmJS',
    build: {
        outDir: '../../wwwroot/vite',
        emptyOutDir: true,
        manifest: true,
        assetsDir: '',
        rollupOptions: {
            input: {
                main: './src/index.js',
            },
            output: {
                entryFileNames: '[name].bundle.js',
                chunkFileNames: '[name].bundle.js',
                assetFileNames: '[name].bundle.[ext]'
            }
        },
    },
}